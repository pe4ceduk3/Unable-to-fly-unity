using Interfaces.FiniteStateMachine;
namespace Structs.FiniteStateMachine
{
    public struct StateMachineStruct
    {
        public IState CurrentState;
        public StateStruct CurrentStateData;
    }
}