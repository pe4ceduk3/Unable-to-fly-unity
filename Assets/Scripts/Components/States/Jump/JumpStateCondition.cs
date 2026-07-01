using Interfaces.FiniteStateMachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Jump
{
    public class JumpStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private InputActionReference jumpAction;
        public bool CanEnter() => false;
        public bool CanExit() => false;
        public bool CanEnterOnInput(InputAction inputAction) => jumpAction.action == inputAction; 
    }
}