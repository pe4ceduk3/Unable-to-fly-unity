using Structs.FiniteStateMachine;

namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachine
    {
        void ChangeState(IState newState);
        IState GetNextState(IState[] states);
    }
}