
namespace Interfaces.FiniteStateMachine
{
    public interface IStateMachine
    {
        void ChangeState(IStateContext newState);
        IStateContext GetNextState(IStateContext[] states);
        void InitializeState(IStateContext newState);
    }
}