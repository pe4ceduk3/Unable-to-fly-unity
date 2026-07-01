using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;

namespace Components.States.Dash
{
    public class DashState : MonoBehaviour, IState
    {
        [Header("Objects")]
        [SerializeField] private Rigidbody2D body;
        [Header("Components")]
        [SerializeField] private Component linearMovement;
        [Header("Components data")]
        [SerializeField] private Component speedData;
        [SerializeField] private Component directionData;
        
        private ILinearMovement _linearMovement;
        
        private ISpeedData _speedData;
        private IDirectionData _directionData;
        
        public void Enter()
        {
            _linearMovement.ApplyLinearSpeed(_speedData, _directionData, body);
        }
        public void Exit() {}
        public void FixedProcess() {}

        private void OnValidate ()
        {
            if (linearMovement is ILinearMovement targetLinearMovement) _linearMovement = targetLinearMovement;
            if (speedData is ISpeedData targetSpeed) _speedData = targetSpeed;
            if (directionData is IDirectionData targetDirection) _directionData = targetDirection;
        }
    }
}