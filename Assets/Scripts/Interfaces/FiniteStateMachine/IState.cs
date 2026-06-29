namespace Interfaces.FiniteStateMachine
{
    public interface IState
    {
        void Enter();
        void Exit();
        void FixedProcess();
    }
}