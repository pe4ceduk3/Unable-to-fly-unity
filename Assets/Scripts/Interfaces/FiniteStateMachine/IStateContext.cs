namespace Interfaces.FiniteStateMachine
{
    public interface IStateContext
    {
        IState State { get; set; }
        IStateCondition Condition { get; set; }
        IStateTransitions Transitions { get; set; }
    }
}