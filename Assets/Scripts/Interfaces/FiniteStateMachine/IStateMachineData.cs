
namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachineData
    {
        IState CurrentState { get; set; }
        IStateContext CurrentStateContext { get; set; }
    }
}
