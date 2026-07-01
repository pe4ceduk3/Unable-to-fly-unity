using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using UnityEngine;
using UnityEngine.InputSystem;
using Interfaces;
    
namespace Components.States.WallGrub
{
    public class WallGrubStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private SerializeInterface<ISurfaceContactData> wallContactData;
        public bool CanEnter() => wallContactData.Value.IsContact; 
        public bool CanExit() => !wallContactData.Value.IsContact; 
        public bool CanEnterOnInput(InputAction inputAction) => false;
    }
}