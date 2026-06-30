using Interfaces.Data;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.Listeners
{
    public class DirectionChanger : MonoBehaviour
    {
        [SerializeReference] private IInputReader inputReader;
        [SerializeField] private InputActionReference right;
        [SerializeField] private InputActionReference left;
        [SerializeField] private InputActionReference stop;
        [SerializeField] private IDirectionData direction;
        private void OnEnable()
        {
            inputReader.OnInput += OnInput;
        }
        private void OnDisable()
        {
            inputReader.OnInput -= OnInput;
        }

        private void OnInput(InputAction inputAction)
        {
            if (inputAction == left.action)
            {
                direction.Direction = -1.0f;
            }
            else if (inputAction == right.action)
            {
                direction.Direction = 1.0f;
            }
            else if (inputAction == stop.action)
            {
                direction.Direction = 0.0f;
            }
        }
    }
}