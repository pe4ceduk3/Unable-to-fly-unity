using System;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Fall
{
    public class FallStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private InputActionReference fallAction;
        [SerializeField] private Component surfaceContact;
        [SerializeField] private Component ground;
        [SerializeField] private Component wall;
        
        private ISurfaceContact _surfaceContact;
        private ISurfaceData _ground;
        private ISurfaceData _wall;
        public bool CanEnter()
        {
            if (_surfaceContact.HasSurface(_ground)) return false;
            if (_surfaceContact.HasSurface(_wall)) return false;
            return true;
        }

        public bool CanExit()
        {
            return _surfaceContact.HasSurface(_ground) || _surfaceContact.HasSurface(_wall);
        }
        public bool CanEnterOnInput(InputAction inputAction)
        {
            return fallAction.action == inputAction;
        }

        private void OnValidate()
        {
            if (surfaceContact is ISurfaceContact targetSurfaceContact) _surfaceContact = targetSurfaceContact;
            if (ground is ISurfaceData targetGround) _ground = targetGround;
            if (wall is ISurfaceData targetWall) _wall = targetWall;
        }
    }
}