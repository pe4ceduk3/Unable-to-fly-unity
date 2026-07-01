using Interfaces;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;

namespace Components.States.Fall
{
    public class FallState : MonoBehaviour, IState
    {
        [Header("Object data")]
        [SerializeField] private Rigidbody2D body;
        [Header("Components")] 
        [SerializeField] private SerializeInterface<ILinearMovement> movement;
        [SerializeField] private SerializeInterface<IGravityAffected> gravityAffected;
        [Header("Components data")]
        [SerializeField] private SerializeInterface<IGravityData> gravityData;
        [SerializeField] private SerializeInterface<IDirectionData> directionData;
        [SerializeField] private SerializeInterface<ISpeedData> speedData;
        
        public void Enter() {}
        public void Exit() {}
        public void FixedProcess()
        {
            movement.Value.ApplyLinearSpeed(speedData.Value, directionData.Value, body);
            gravityAffected.Value.ApplyGravity(gravityData.Value, body);
        }
    }
}