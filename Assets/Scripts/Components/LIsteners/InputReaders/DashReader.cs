using Interfaces.Listeners;
using System;
using UnityEngine;

namespace Components.Listeners.InputReaders
{
    public class DashReader : MonoBehaviour, IInputReader
    {
        public event Action OnShot;

        public void OnDash()
        {
            OnShot?.Invoke();
        }
    }
}