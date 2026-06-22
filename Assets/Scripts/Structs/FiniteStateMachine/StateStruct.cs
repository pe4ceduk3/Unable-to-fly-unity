using Interfaces.FiniteStateMachine;
namespace Structs.FiniteStateMachine
{
    public struct StateStruct
    {
        public IState[] NextStateOnExit;
        public IState[] NextStateWhileProcess;
    }
}