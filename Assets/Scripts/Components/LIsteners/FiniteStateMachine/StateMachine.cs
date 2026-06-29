using Interfaces.FiniteStateMachine;
using UnityEngine;
using IState = Interfaces.FiniteStateMachine.IState;

namespace Components.FiniteStateMachine
{
    public class StateMachine : MonoBehaviour, IStateMachine, IStateMachineData
    {
        public IState CurrentState { get; set; }
        public IStateContext CurrentStateContext { get; set; }

        public void ChangeState(IState newState)
        {
            CurrentState.Exit();
            InitializeState(newState);
        }
        public IState GetNextState(IState[] states)
        {
            Debug.Log("hello");
            return null;
        }

        public void InitializeState(IState state)
        {
            CurrentState = state;
            state.Enter();
        }

        private void Update()
        {
            CurrentState.FixedProcess();
            
        }
    }
}