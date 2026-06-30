using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    public class StateContext : MonoBehaviour, IStateContext
    {
        public IStateCondition Condition { get; set; }
        public IState State { get; set; }
        public IStateTransitions Transitions { get; set; }
    }
}