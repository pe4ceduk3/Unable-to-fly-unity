using Interfaces.FiniteStateMachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Jump
{
    public class JumpStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private InputActionReference jumpAction;
        [SerializeField] private Rigidbody2D body;
        public bool CanEnter() => false;
        public bool CanEnterOnInput(InputAction inputAction) => jumpAction.action == inputAction; 
        public bool CanExit() => body.linearVelocity.y <= 0.0f;
    }
}