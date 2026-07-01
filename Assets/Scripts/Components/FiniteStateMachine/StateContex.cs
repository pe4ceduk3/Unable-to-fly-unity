using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    public class StateContext : MonoBehaviour, IStateContext
    {
        [SerializeField] private Component state;
        [SerializeField] private Component condition;
        [SerializeField] private Component transition;
        public IState State { get; set; }
        public IStateCondition Condition { get; set; }
        public IStateTransitions Transitions { get; set; }

        private void OnValidate()
        {
            if (state is IState targetState) State = targetState;
            if (condition is IStateCondition targetCondition) Condition = targetCondition;
            if (transition is IStateTransitions targetTransitions) Transitions = targetTransitions;
        }
    }
}