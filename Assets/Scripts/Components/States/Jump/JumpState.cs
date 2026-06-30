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
        [SerializeReference] private IBallisticsProcessor ballisticsProcessor;
        [SerializeReference] private ILinearMovement linearMovement;
        [Header("Components data")]
        [SerializeReference] private ISpeedData speedData;
        [SerializeReference] private IBallisticsData ballisticsData;
        [SerializeReference] private IGravityData gravityData;
        [SerializeReference] private IDirectionData directionData;
        public void Enter()
        {
            ballisticsProcessor.SetStartVelocity(ballisticsData, body);
        }
        public void Exit()
        {
            body.linearVelocity = Vector2.zero;
        }
        public void FixedProcess()
        {
            ballisticsProcessor.ApplyGravity(ballisticsData, gravityData, body);
            linearMovement.ApplyLinearSpeed(speedData, directionData, body);
        }
    }
}