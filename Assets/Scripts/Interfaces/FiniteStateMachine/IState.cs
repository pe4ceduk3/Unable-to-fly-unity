namespace Interfaces.FiniteStateMachine
{
    public interface IState
    {
        bool CanEnter();
        bool CanExit();
        void Enter();
        void Exit();
        void FixedProcess();
    }
}