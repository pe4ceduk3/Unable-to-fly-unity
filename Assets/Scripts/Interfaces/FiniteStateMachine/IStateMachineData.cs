
namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachineData
    {
        IState CurrentState { get; set; }
        IStateData CurrentStateData { get; set; }
    }
}