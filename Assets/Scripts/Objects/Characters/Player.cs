using UnityEngine;
using Structs.Movement;
using UnityEngine.InputSystem;
using Components.Listeners;
using Interfaces.Listeners;
using Interfaces.Movement;

namespace Objects.Characters
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class Player : MonoBehaviour
    {
        // if (other.gameObject.TryGetComponent(out Player player))
        [Header("Player Properties")]
        [SerializeField] private GravityStruct gravityData;
        [SerializeField] private MotionProfilerStruct motionProfilerData;
        [SerializeField] private BallisticsProcessorStruct ballisticsProcessorData;
        [SerializeField] private SurfaceContactStruct wallContactData;
        [SerializeField] private SurfaceContactStruct groundContactData;
        [Header("Player Components")]
        [SerializeField] private Rigidbody2D body;
        [SerializeField] private IGravityAffected _gravity;
        [SerializeField] private IMotionProfiler _movement;
        [SerializeField] private ISurfaceContact _surfaceContact;
        [SerializeField] private IBallisticsProcessor _ballisticsProcessor;
        [SerializeField] private InputReaderComponent _inputReader;

        private bool _isJumping = false;
        private bool _isGround = false;

        private void OnEnable()
        {
            _inputReader.OnJumpEvent += Jump;
        }
        private void Jump()
        {
            _isJumping = true;
            _ballisticsProcessor.SetStartVelocity(ballisticsProcessorData, body);
        }
        private void FixedUpdate()
        {
            ApplyGravity();
            ApplyMovement();
            SurfaceCheck();
        }
        private void SurfaceCheck()
        {
            _isGround = _surfaceContact.CheckContact(wallContactData);
            _isGround = _surfaceContact.CheckContact(groundContactData);
            if (_isGround) _isJumping = false;
        }
        private void ApplyMovement()
        {
            _movement.LinearMove(ref motionProfilerData, body);
        }
        private void ApplyGravity()
        {
            if (_isJumping)
                _ballisticsProcessor.ApplyGravity(ballisticsProcessorData, body);
            else if (body.linearVelocity.y <= 0)    
                _gravity.ApplyGravity(gravityData, body);
        }
    }
}