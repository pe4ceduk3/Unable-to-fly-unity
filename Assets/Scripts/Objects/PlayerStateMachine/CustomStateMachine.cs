using Interfaces.FiniteStateMachine;
using Structs.FiniteStateMachine;
using UnityEngine;

namespace Objects.PlayerStateMachine
{
    public class CustomStateMachine : MonoBehaviour, IStateMachine
    {
        private StateMachineStruct _stateMachine;
        
        public IState GetNextState(IState[] statesArr)
        {
            foreach (IState state in statesArr)
                if (state.CanEnter()) return state;
            return null;
        }
        public void ChangeState(IState newState)
        {
            if (newState == null) return;
            if (newState == _stateMachine.CurrentState) return;
            
            _stateMachine.CurrentState.Exit();
            _stateMachine.CurrentState = newState;
            _stateMachine.CurrentState.Enter();
        }
        private void Awake()
        {
            _stateMachine.CurrentState.Enter();
        }
        private void FixedUpdate()
        {
            if (_stateMachine.CurrentState != null) 
                _stateMachine.CurrentState.FixedProcess();
            StateChangeIfCan();
        }
        private void StateChangeIfCan()
        {
            StateStruct stateData = _stateMachine.CurrentStateData;
            IState newState = GetNextState(stateData.NextStateOnExit) ?? 
                              GetNextState(stateData.NextStateWhileProcess);
            if (newState != null) ChangeState(newState);
        }
    }
}