using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.States.WallGrub
{
    public class WallGrub : MonoBehaviour, IState
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