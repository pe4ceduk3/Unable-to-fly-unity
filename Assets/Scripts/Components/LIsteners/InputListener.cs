using System;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.Listeners
{
    [Serializable]
    public class InputListener : MonoBehaviour, IInputReader
    {
        [SerializeField] private InputActionAsset inputActionAsset;
        public event Action<InputAction> OnInput;

        private void OnEnable()
        {
            foreach ( InputActionMap inputActionMap in inputActionAsset.actionMaps )
            {
                inputActionMap.actionTriggered += OnAction;
            }
        }

        private void OnDisable()
        {
            foreach (InputActionMap inputActionMap in inputActionAsset.actionMaps)
            {
                inputActionMap.actionTriggered += OnAction;
            }
        }

        private void OnAction(InputAction.CallbackContext context)
        {
            if ( context.performed )
            {
                OnInput?.Invoke(context.action);
            }
        }
    }
}