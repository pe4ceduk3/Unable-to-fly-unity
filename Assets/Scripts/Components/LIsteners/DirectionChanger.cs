using System;
using Interfaces.Data;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.Listeners
{
    public class DirectionChanger : MonoBehaviour
    {
        [SerializeField] private Component inputReader;
        [SerializeField] private Component direction;
        
        [SerializeField] private InputActionReference right;
        [SerializeField] private InputActionReference left;
        [SerializeField] private InputActionReference stop;
        
        private IInputReader _inputReader;
        private IDirectionData _direction;

        private void OnValidate()
        {
            if (inputReader is IInputReader targetInputReader) _inputReader = targetInputReader;
            if (direction is IDirectionData targetDirection) _direction = targetDirection;
        }

        private void OnEnable()
        {
            _inputReader.OnInput += OnInput;
        }
        private void OnDisable()
        {
            _inputReader.OnInput -= OnInput;
        }

        private void OnInput(InputAction inputAction)
        {
            if (inputAction == left.action)
            {
                _direction.Direction = -1.0f;
            }
            else if (inputAction == right.action)
            {
                _direction.Direction = 1.0f;
            }
            else if (inputAction == stop.action)
            {
                _direction.Direction = 0.0f;
            }
        }
    }
}