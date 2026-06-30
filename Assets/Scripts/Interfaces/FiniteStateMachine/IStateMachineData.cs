
namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachineData
    {
        IStateContext CurrentStateContext { get; set; }
    }
}
