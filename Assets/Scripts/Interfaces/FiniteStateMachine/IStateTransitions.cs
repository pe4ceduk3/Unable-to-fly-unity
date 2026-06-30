namespace Interfaces.FiniteStateMachine
{
    public interface IStateTransitions
    {
        IStateContext[] NextStatesOnExit { get; set; }
        IStateContext[] NextStatesWhileProcess { get; set; }
        IStateContext[] NextStatesOnInput { get; set; }
    }
}