namespace Interfaces.FiniteStateMachine
{
    public interface IStateData
    {
        IState[] NextStatesOnExit { get; set; }
        IState[] NextStatesWhileProcess { get; set; }
        IState[] NextStatesOnInput { get; set; }
    }
}