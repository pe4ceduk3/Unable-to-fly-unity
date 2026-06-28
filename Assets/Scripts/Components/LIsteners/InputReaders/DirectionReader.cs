using Interfaces.Listeners;
using System;
using UnityEngine.InputSystem;
using UnityEngine;

namespace Components.Listeners.InputReaders
{
    public class DirectionReader : MonoBehaviour, IInputAxisReader
    {
        public event Action<float> OnAxisChanged;
        
        private void OnHeading(InputAction.CallbackContext context)
        {
            float value = context.ReadValue<float>();
            OnAxisChanged?.Invoke(value);
        }
    }
}