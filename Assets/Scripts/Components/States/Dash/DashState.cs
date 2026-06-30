using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
using UnityEngine;

namespace Components.States.Dash
{
    public class DashState : MonoBehaviour, IState
    {
        [Header("Objects")]
        [SerializeField] private Rigidbody2D body;
        [Header("Components")]
        [SerializeReference] private ILinearMovement linearMovement;
        [Header("Components data")]
        [SerializeReference] private ISpeedData speedData;
        [SerializeReference] private IDirectionData directionData;
        public void Enter()
        {
            linearMovement.ApplyLinearSpeed(speedData, directionData, body);
        }
        public void Exit() {}
        public void FixedProcess() {}
    }
}