using UnityEngine.InputSystem;

namespace Interfaces.FiniteStateMachine
{
    public interface IStateCondition
    {
        bool CanEnter();
        bool CanEnterOnInput(InputAction inputAction);
        bool CanExit();
    }
}