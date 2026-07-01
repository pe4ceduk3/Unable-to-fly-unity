using Interfaces.FiniteStateMachine;

namespace Components.FiniteStateMachine
{
    public class StateTransitions : IStateTransitions
    {
        public IStateContext[] NextStatesOnExit { get; set; }
        public IStateContext[] NextStatesOnInput { get; set; }
        public IStateContext[] NextStatesWhileProcess { get; set; }
    }
}