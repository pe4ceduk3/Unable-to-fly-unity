using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;
using Interfaces;

namespace Components.States.Dash
{
    public class DashState : MonoBehaviour, IState
    {
        [Header("Objects")]
        [SerializeField] private Rigidbody2D body;
        [Header("Components")] 
        [SerializeField] private SerializeInterface<ILinearMovement> linearMovement;

        [Header("Components data")] 
        [SerializeField] private SerializeInterface<IDirectionData> direction;
        [SerializeField] private SerializeInterface<ISpeedData> speed;
          
        public void Enter()
        {
            linearMovement.Value.ApplyLinearSpeed(speed.Value, direction.Value, body);
        }
        public void Exit() {}
        public void FixedProcess() {}
    }
}