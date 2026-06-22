using UnityEngine;
using Interfaces.FiniteStateMachine;
using Interfaces.Movement;
//using Structs.FiniteStateMachine;
using Structs.Movement;

namespace Objects.PlayerStateMachine
{
    public class JumpState : MonoBehaviour, IState
    {
        [Header("Data")]
        [SerializeField] 
        private BallisticsProcessorStruct jumpData;
        [SerializeField]
        private MotionProfilerStruct moveData;
        [Header("Components")]
        [SerializeField]
        private IMotionProfiler _moveProfiler;
        [SerializeField]
        private IBallisticsProcessor _jumpProcessor;
        [Header("Body")]
        [SerializeField] 
        private Rigidbody2D body;
        
        public void Enter()
        {
            _jumpProcessor.SetStartVelocity(jumpData, body);
        }

        public void Exit() {return;}
        public bool CanExit()
        {
            return true;
        }
        public bool CanEnter()
        {
            return true;
        }

        public void FixedProcess()
        {
            _jumpProcessor.ApplyGravity(jumpData, body);
        }
    }
}