using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.FiniteStateMachine
{
    public class StateMachine : MonoBehaviour, IStateMachine, IStateMachineData
    {
        public IStateContext CurrentStateContext { get; set; }
        [SerializeReference] private IInputReader inputReader;

        public void ChangeState(IStateContext newStateContext)
        {
            CurrentStateContext.State.Exit();
            InitializeState(newStateContext);
        }
        public IStateContext GetNextState(IStateContext[] states)
        {
            foreach (IStateContext stateContext in states)
            {
                if (stateContext.Condition.CanEnter())
                {
                    return stateContext;
                }
            }
            return null;
        }
        public void InitializeState(IStateContext state)
        {
            CurrentStateContext = state;
            state.State.Enter();
        }
        private void FixedUpdate()
        {
            CurrentStateContext.State.FixedProcess();
            TryExitState(CurrentStateContext);
        }
        private void TryExitState(IStateContext stateContext)
        {
            if (stateContext.Condition.CanExit())
            {
                IStateContext newState = GetNextState(stateContext.Transitions.NextStatesOnExit);
                if (newState == null) return;
                ChangeState(newState); 
            }
        } 
        private void OnEnable()
        {
            inputReader.OnInput += OnInput;
        }
        private void OnDisable()
        {
            inputReader.OnInput -= OnInput;
        }
        private void OnInput(InputAction inputAction)
        {
            foreach (IStateContext stateContext in CurrentStateContext.Transitions.NextStatesOnInput)
            {
                if (stateContext.Condition.CanEnterOnInput(inputAction))
                {
                    ChangeState(stateContext);
                }
            }
        }
    }
}







