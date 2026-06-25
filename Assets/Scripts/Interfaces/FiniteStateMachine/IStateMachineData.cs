using Structs.FiniteStateMachine;

namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachineData
    {
        IState CurrentState { get; set; }
        StateStruct CurrentStateData { get; set; }
    }
}