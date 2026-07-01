using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.WallGrub
{
    public class WallGrubCondition : MonoBehaviour, IStateCondition
    {
        [SerializeReference] private ISurfaceContact surfaceChecker;
        [SerializeReference] private ISurfaceData wall;
        public bool CanEnter()
        {
            return surfaceChecker.HasSurface(wall);
        }
        public bool CanExit()
        {
           return !surfaceChecker.HasSurface(wall);
        }
        public bool CanEnterOnInput(InputAction inputAction) => false;
    }
}