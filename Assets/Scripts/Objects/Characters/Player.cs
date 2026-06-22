using Components.Movement;
using UnityEngine;
using Structs.Movement;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Components.Listeners;
namespace Objects.Characters
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Player : MonoBehaviour
    {
        // if (other.gameObject.TryGetComponent(out Player player))
        [Header("Player Properties")]
        [SerializeField] private GravityStruct gravityData;
        [SerializeField] private MotionProfilerStruct motionProfilerData;
        [FormerlySerializedAs("ballisticsCalculatorData")] [FormerlySerializedAs("ballisticsData")] [SerializeField] private BallisticsProcessorStruct ballisticsProcessorData;
        [SerializeField] private SurfaceContactStruct wallContactData;
        [SerializeField] private SurfaceContactStruct groundContactData;
        [Header("Player Components")]
        [SerializeField] private Rigidbody2D body;
        [SerializeField] private GravityComponent gravity;
        [SerializeField] private MovementComponent movement;
        [SerializeField] private SurfaceContactComponent surfaceContact;
        [FormerlySerializedAs("ballisticsCalculate")] [SerializeField] private BallisticsProcessorComponent ballisticsProcessor;

        private bool _isJumping = false;
        private bool _isGround = false;
        
        private void OnMove(InputValue value) 
        {
            Vector2 moveDirection = value.Get<Vector2>();
            motionProfilerData.direction = moveDirection.x;
        }
        private void OnJump()
        {
            _isJumping = true;
            ballisticsProcessor.SetStartVelocity(ballisticsProcessorData, body);
        }
        private void FixedUpdate()
        {
            ApplyGravity();
            ApplyMovement();
            SurfaceCheck();
        }

        private void SurfaceCheck()
        {
            _isGround = surfaceContact.CheckContact(wallContactData);
            _isGround = surfaceContact.CheckContact(groundContactData);
            if (_isGround) _isJumping = false;
        }
        private void ApplyMovement()
        {
            movement.LinearMove(ref motionProfilerData, body);
        }
        private void ApplyGravity()
        {
            if (_isJumping)
                ballisticsProcessor.ApplyGravity(ballisticsProcessorData, body);
            else if (body.linearVelocity.y <= 0)    
                gravity.ApplyGravity(gravityData, body);
        }
    }
}