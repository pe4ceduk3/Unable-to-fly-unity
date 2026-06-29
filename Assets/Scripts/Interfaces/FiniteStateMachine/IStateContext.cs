namespace Interfaces.FiniteStateMachine
{
    public interface IStateContext
    {
        IState CurrentState { get; set; }
        IStateCondition Condition { get; set; }
        IState[] OnExit { get; set; }
        IState[] WhileProcess { get; set; }
        IState[] OnInput { get; set; }
    }
}