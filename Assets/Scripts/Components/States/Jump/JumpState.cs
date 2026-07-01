using System;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;

namespace Components.States.Jump
{
    public class JumpState : MonoBehaviour, IState
    {
        [Header("Objects")]
        [SerializeField] private Rigidbody2D body;
        [Header("Components")]
        [SerializeField] private Component ballisticsProcessor;
        [SerializeField] private Component linearMovement;
        [Header("Components data")]
        [SerializeField] private Component ballisticsData;
        [SerializeField] private Component directionData;
        [SerializeField] private Component gravityData;
        [SerializeField] private Component speedData;
        
        private IBallisticsProcessor _ballisticsProcessor;
        private ILinearMovement _linearMovement;
        
        private IBallisticsData _ballisticsData;
        private IDirectionData _directionData;
        private IGravityData _gravityData;
        private ISpeedData _speedData;

        private void OnValidate()
        {
            if (ballisticsData is IBallisticsProcessor targetBallisticsProcessor) _ballisticsProcessor = targetBallisticsProcessor;
            if (linearMovement is ILinearMovement targetLinearMovement) _linearMovement = targetLinearMovement;
            
            if (ballisticsData is IBallisticsData targetBallisticsData) _ballisticsData = targetBallisticsData;
            if (directionData is IDirectionData targetDirectionData) _directionData = targetDirectionData;
            if (gravityData is IGravityData targetGravityData) _gravityData = targetGravityData;
            if (speedData is ISpeedData targetSpeedData) _speedData = targetSpeedData;
        }

        public void Enter()
        {
            _ballisticsProcessor.SetStartVelocity(_ballisticsData, body);
        }
        public void Exit()
        {
            body.linearVelocity = Vector2.zero;
        }
        public void FixedProcess()
        {
            _ballisticsProcessor.ApplyGravity(_ballisticsData, _gravityData, body);
            _linearMovement.ApplyLinearSpeed(_speedData, _directionData, body);
        }
    }
}