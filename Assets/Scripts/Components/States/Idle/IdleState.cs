using System;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Idle
{
    public class IdleState : MonoBehaviour, IStateCondition
    {
        [SerializeField] private Component surfaceContact;
        [SerializeField] private Component ground;
        
        private ISurfaceContact _surfaceContact;
        private ISurfaceData _ground;
        
        public bool CanEnter()
        {
            return _surfaceContact.HasSurface(_ground);
        }

        public bool CanExit()
        {
            return !_surfaceContact.HasSurface(_ground);
        }
        public bool CanEnterOnInput(InputAction inputAction) => false;

        private void OnValidate()
        {
            if (surfaceContact is ISurfaceContact targetSurfaceContact) _surfaceContact = targetSurfaceContact;
            if (ground is ISurfaceData targetGround) _ground = targetGround;
        }
    }
}