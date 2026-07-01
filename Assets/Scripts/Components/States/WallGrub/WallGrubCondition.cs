using System;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.WallGrub
{
    public class WallGrubCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private Component surfaceContact;
        [SerializeField] private Component wall;
        
        private ISurfaceContact _surfaceContact;
        private ISurfaceData _wall;
        
        public bool CanEnter()
        {
            return _surfaceContact.HasSurface(_wall);
        }
        public bool CanExit()
        {
           return !_surfaceContact.HasSurface(_wall);
        }
        public bool CanEnterOnInput(InputAction inputAction) => false;

        private void OnValidate()
        {
            if (surfaceContact is ISurfaceContact targetSurfaceContact) _surfaceContact = targetSurfaceContact;
            if (wall is ISurfaceData targetWall) _wall = targetWall;
        }
    }
}