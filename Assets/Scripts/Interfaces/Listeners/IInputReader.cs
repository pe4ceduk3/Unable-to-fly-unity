using System;
using UnityEngine.InputSystem;

namespace Interfaces.Listeners
{
    public interface IInputReader
    {
        public event Action<InputAction> OnInput;
    }
}