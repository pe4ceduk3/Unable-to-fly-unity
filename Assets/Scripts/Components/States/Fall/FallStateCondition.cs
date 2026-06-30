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
        
        [SerializeReference] private ISurfaceContact surfaceContact;
        
        [SerializeReference] private ISurfaceData ground;
        [SerializeReference] private ISurfaceData wall;
        public bool CanEnter()
        {
            if (surfaceContact.HasSurface(ground)) return false;
            if (surfaceContact.HasSurface(wall)) return false;
            return true;
        }

        public bool CanExit()
        {
            return surfaceContact.HasSurface(ground) || surfaceContact.HasSurface(wall);
        }
        public bool CanEnterOnInput(InputAction inputAction)
        {
            return fallAction.action == inputAction;
        }
    }
}