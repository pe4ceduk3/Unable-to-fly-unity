using Interfaces.FiniteStateMachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Components.States.Dash
{
    public class DashStateCondition : MonoBehaviour,IStateCondition
    {
        [SerializeField] private InputActionReference dashAction;
        public bool CanEnter() => false;
        public bool CanExit() => false;
        public bool CanEnterOnInput(InputAction inputAction)
        {
            return dashAction.action == inputAction;
        }
    }
}