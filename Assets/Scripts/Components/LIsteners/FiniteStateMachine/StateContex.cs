using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    public class StateContext : MonoBehaviour, IStateContext
    {
        public IStateCondition Condition { get; set; }
        public IState CurrentState { get; set; }
        public IState[] OnExit { get; set; }
        public IState[] WhileProcess { get; set; }
        public IState[] OnInput { get; set; }
    }
}