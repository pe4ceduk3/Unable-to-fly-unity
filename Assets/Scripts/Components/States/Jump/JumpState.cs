using Interfaces;
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
        [SerializeField] private SerializeInterface<IBallisticsProcessor> ballisticsProcessor;
        [SerializeField] private SerializeInterface<ILinearMovement> linearMovement;
        [Header("Components data")]
        [SerializeField] private SerializeInterface<IBallisticsData> ballisticsData;
        [SerializeField] private SerializeInterface<IDirectionData> directionData;
        [SerializeField] private SerializeInterface<ISpeedData> speedData;
        
        public void Enter()
        {
            ballisticsProcessor.Value.SetStartVelocity(ballisticsData.Value, body);
        }
        public void Exit() { body.linearVelocity = Vector2.zero; }
        public void FixedProcess()
        {
            ballisticsProcessor.Value.ApplyGravity(ballisticsData.Value, body);
            linearMovement.Value.ApplyLinearSpeed(speedData.Value, directionData.Value, body);
        }
    }
}
