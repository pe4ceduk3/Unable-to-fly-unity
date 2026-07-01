using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    public class StateTransitions : MonoBehaviour, IStateTransitions
    {
        public IStateContext[] NextStatesOnExit { get; set; }
        public IStateContext[] NextStatesOnInput { get; set; }
        public IStateContext[] NextStatesWhileProcess { get; set; }
    }
}