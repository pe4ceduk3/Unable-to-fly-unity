using System;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using Interfaces;

namespace Components.States.Idle
{
    public class IdleStateCondition : MonoBehaviour, IStateCondition
    {
        [SerializeField] private SerializeInterface<ISurfaceContactData> groundContactData;
        public bool CanEnter() => groundContactData.Value.IsContact;
        public bool CanExit() => !groundContactData.Value.IsContact;
        public bool CanEnterOnInput(InputAction inputAction) => false;
    }
}