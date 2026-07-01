using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Idle
{
    public class IdleState : MonoBehaviour, IStateCondition
    {
        [SerializeReference] private ISurfaceContact surfaceChecker;
        [SerializeReference] private ISurfaceData ground;
        public bool CanEnter()
        {
            return surfaceChecker.HasSurface(ground);
        }

        public bool CanExit()
        {
            return !surfaceChecker.HasSurface(ground);
        }
        public bool CanEnterOnInput(InputAction inputAction) => false;
    }
}