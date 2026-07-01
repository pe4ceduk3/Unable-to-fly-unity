using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.States.Idle
{
    public class IdleStateCondition : MonoBehaviour, IState
    {
        [SerializeField] private Rigidbody2D body;
        public void Enter()
        {
            body.linearVelocity = Vector2.zero;
        }
        public void Exit() {}
        public void FixedProcess() {}
    }
}