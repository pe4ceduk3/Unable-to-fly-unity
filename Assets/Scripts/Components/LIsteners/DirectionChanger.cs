using System;
using Interfaces.Data;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;
using Interfaces;

namespace Components.Listeners
{
    [Serializable]
    public class DirectionChanger : MonoBehaviour
    {
        [SerializeField] private InputActionReference right;
        [SerializeField] private InputActionReference left;
        [SerializeField] private InputActionReference stop;

        [SerializeField] private SerializeInterface<IDirectionData> direction;
        [SerializeField] private SerializeInterface<IInputReader> inputReader;
 

        private void OnEnable()
        {
            inputReader.Value.OnInput += OnInput;
        }
        private void OnDisable()
        {
            inputReader.Value.OnInput -= OnInput;
        }

        private void OnInput(InputAction inputAction)
        {
            if (inputAction == left.action)
            {
                direction.Value.Direction = -1.0f;
            }
            else if (inputAction == right.action)
            {
                direction.Value.Direction = 1.0f;
            }
            else if (inputAction == stop.action)
            {
                direction.Value.Direction = 0.0f;
            }
        }
    }
}