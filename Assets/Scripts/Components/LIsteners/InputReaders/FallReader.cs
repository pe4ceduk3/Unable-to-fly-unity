using Interfaces.Listeners;
using System;
using UnityEngine;

namespace Components.Listeners.InputReaders
{
    public class FallReader : MonoBehaviour, IInputReader
    {
        public event Action OnShot;

        public void OnFall()
        {
            OnShot?.Invoke();
        }
    }
}