using Interfaces.FiniteStateMachine;
namespace Structs.FiniteStateMachine
{
    public struct StateMachineStruct : IStateMachineData
    {
        public IState CurrentState { get; set; }
        public StateStruct CurrentStateData { get; set; }
    }
}