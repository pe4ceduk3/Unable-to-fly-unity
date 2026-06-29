# Plan

```cs
// how to work with InputActionAsset
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActionAssetProcessor : MonoBehaviour
{
    [SerializeField] private InputActionAsset inputActionAsset;
    public event Action<string> OnActionTriggered;

    private void OnEnable()
    {
        if (inputActionAsset == null) return;
        inputActionAsset.Enable();
        foreach (InputActionMap map in inputActionAsset.actionMaps)
        {
            foreach (InputAction action in map.actions)
            {
                action.performed += HandleAction;
            }
        }
    }
    private void OnDisable()
    {
        if (inputActionAsset == null) return;

        foreach (InputActionMap map in inputActionAsset.actionMaps)
        {
            foreach (InputAction action in map.actions)
            {
                action.performed -= HandleAction;
            }
        }
        inputActionAsset.Disable();
    }
    private void HandleAction(InputAction.CallbackContext context)
    {
        string actionName = context.action.name;
        OnActionTriggered?.Invoke(actionName);
    }
}
```
