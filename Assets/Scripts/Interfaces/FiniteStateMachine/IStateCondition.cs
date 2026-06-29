namespace Interfaces.FiniteStateMachine
{
    public interface IStateCondition
    {
        bool CanEnter();
        bool CanExit();
    }
}