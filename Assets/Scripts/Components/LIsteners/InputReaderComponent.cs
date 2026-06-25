using System;
using UnityEngine.InputSystem;

namespace Components.Listeners
{
    public class InputReaderComponent
    {
        public event Action OnJumpEvent;
        public event Action OnDashEvent;
        public event Action OnFallEvent;
        public event Action<InputValue> OnHeadingEvent;
        public event Action OnInteractEvent;
        public event Action OnAttackEvent;
        public event Action OnBlockEvent;
        public event Action OnShot;
        public event Action OnPauseEvent;

        private void OnJump()
        {
            OnJumpEvent?.Invoke();
        }

        private void OnDash()
        {
            OnDashEvent?.Invoke();
        }

        private void OnFall()
        {
            OnFallEvent?.Invoke();
        }

        private void OnHeading(InputValue value)
        {
            OnHeadingEvent?.Invoke(value);
        }

        private void OnInteract()
        {
            OnInteractEvent?.Invoke();
        }

        private void OnAttack()
        {
            OnAttackEvent?.Invoke();
        }

        private void OnBlock()
        {
            OnBlockEvent?.Invoke();
        }

        private void OnShoot()
        {
            OnShot?.Invoke();
        }

        private void OnPause()
        {
            OnPauseEvent?.Invoke();
        }
    }
}