using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Fall
{
    public class FallState : MonoBehaviour, IState
    {
        [Header("Object data")]
        [SerializeField] private Rigidbody2D body;
        [SerializeField] private InputActionReference fallAction;
        [Header("Components")]
        [SerializeReference] private ILinearMovement movement;
        [SerializeReference] private IGravityAffected gravityAffected;
        [Header("Components data")]
        [SerializeReference] private IGravityData gravityData;
        [SerializeReference] private IGravityData fastFallGravityData;
        [SerializeReference] private IDirectionData directionData;
        [SerializeReference] private ISpeedData speedData;
        
        private bool _isFastFall;
        
        public void Enter() {}
        public void Exit() {}
        public void FixedProcess()
        {
            movement.ApplyLinearSpeed(speedData, directionData, body);
            ApplyGravity();
        }

        private void ApplyGravity()
        {
            IGravityData currentGravity = gravityData;
            if (_isFastFall) currentGravity = fastFallGravityData;
            gravityAffected.ApplyGravity(currentGravity, body);
        }
        private void OnEnable()
        {
            fallAction.action.performed += OnInputPressed;
        }
        private void OnDisable()
        {
            fallAction.action.performed -= OnInputPressed;
        }
        private void OnInputPressed(InputAction.CallbackContext context)
        {
            if (context.action != fallAction.action) return;
            if (context.performed) _isFastFall = true;
            if (context.canceled) _isFastFall = false;
        }
    }
}