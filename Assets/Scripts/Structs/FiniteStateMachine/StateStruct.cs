using Interfaces.FiniteStateMachine;
namespace Structs.FiniteStateMachine
{
    public struct StateStruct : IStateData
    {
        public IState[] NextStatesOnExit { get; set; }
        public IState[] NextStatesWhileProcess { get; set; }
        public IState[] NextStatesOnInput { get; set; }
    }
}