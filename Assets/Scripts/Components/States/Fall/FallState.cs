using System;
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
        [SerializeField] private Component movement;
        [SerializeField] private Component gravityAffected;
        [Header("Components data")]
        [SerializeField] private Component gravityData;
        [SerializeField] private Component directionData;
        [SerializeField] private Component fastFallGravityData;
        [SerializeField] private Component speedData;
        
        private ILinearMovement _movement;
        private IGravityAffected _gravityAffected;
        
        private IGravityData _gravityData;
        private IGravityData _fastFallGravityData;
        private IDirectionData _directionData;
        private ISpeedData _speedData;
        
        private bool _isFastFall;
        
        public void Enter() {}
        public void Exit() {}
        public void FixedProcess()
        {
            _movement.ApplyLinearSpeed(_speedData, _directionData, body);
            ApplyGravity();
        }

        private void OnValidate()
        {
            if (movement is ILinearMovement targetMovement)
                _movement = targetMovement;
            if (gravityAffected is IGravityAffected targetGravityAffected)
                _gravityAffected = targetGravityAffected;
            
            if (gravityData is IGravityData targetGravityData)
                _gravityData = targetGravityData;
            if (fastFallGravityData is IGravityData targetFastFallGravityData)
                _fastFallGravityData = targetFastFallGravityData;
            if (directionData is IDirectionData targetDirectionData)
                _directionData = targetDirectionData;
            if (speedData is ISpeedData targetSpeedData)
                _speedData = targetSpeedData;
        }

        private void ApplyGravity()
        {
            IGravityData currentGravity = _gravityData;
            if (_isFastFall) currentGravity = _fastFallGravityData;
            _gravityAffected.ApplyGravity(currentGravity, body);
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