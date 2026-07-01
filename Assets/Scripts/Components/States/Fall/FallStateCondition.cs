using UnityEngine;
using Interfaces;
using Interfaces.Data;
using UnityEngine.InputSystem;
using Interfaces.FiniteStateMachine;

namespace Components.States.Fall
{
    public class FallStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private InputActionReference fallAction;
        [SerializeField] private SerializeInterface<ISurfaceContactData> wallContactData;
        [SerializeField] private SerializeInterface<ISurfaceContactData> groundContactData;
        
        public bool CanEnter() => !HasAnyContact();
        public bool CanExit() => HasAnyContact();
        public bool CanEnterOnInput(InputAction inputAction) => false;
        private bool HasAnyContact() => wallContactData.Value.IsContact || groundContactData.Value.IsContact;
    }
}