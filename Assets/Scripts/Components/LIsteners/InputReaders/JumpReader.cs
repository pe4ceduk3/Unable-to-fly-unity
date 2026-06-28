using Interfaces.Listeners;
using System;
using UnityEngine;

namespace Components.Listeners.InputReaders
{
    public class JumpReader : MonoBehaviour, IInputReader
    {
        public event Action OnShot;

        public void OnJump()
        {
            OnShot?.Invoke();
        }
    }
}