using Components.FiniteStateMachine;
using Components.States.Dash;
using Components.States.Fall;
using Components.States.Idle;
using UnityEngine;
using Interfaces;
using Interfaces.Data;
using Interfaces.FiniteStateMachine;
using Interfaces.Listeners;
using Interfaces.Movement;
using UnityEngine.InputSystem;
using Components.Data;

namespace Objects.Player
{
    public class PlayerData
    {
        [SerializeField] private Rigidbody2D _body;
        
        // ===data===
        private IDamageableData _damageableData;
        private IEnergyData _energyData;
        private ISurfaceContactData _groundContactData;
        private ISurfaceContactData _wallContactData;
        private IDirectionData _directionData;
        private IGravityData _gravityData;
        
        private ISpeedData _jumpSpeedData;
        private IBallisticsData _jumpBallisticsData;

        // ===fsm===
        private IStateMachine _stateMachine;
        private IStateTransitions _transitions;
        //idle
        private IStateCondition _idleStateCondition;
        private IStateContext _idleStateContext;
        private IState _idleState;
        //dash
        [SerializeField] private SerializeInterface<ISpeedData> _dashSpeedData;
        [SerializeField] private InputActionReference _dashAction;
        private IStateCondition _dashStateCondition;
        private IStateContext _dashStateContext;
        private IState _dashState;
        //jump
        private IStateCondition _jumpStateCondition;
        private IStateContext _jumpStateContext;
        private IState _jumpState;
        //fall
        private IStateCondition _fallStateCondition;
        private IStateContext _fallStateContext;
        private IState _fallState;
        //wall
        private IStateCondition _wallGrubStateCondition;
        private IStateContext _wallGrubStateContext;
        private IState _wallGrubState;
        
        // ===components===
        private IBallisticsProcessor _ballisticsProcessor;
        private IGravityAffected _gravityAffected;
        private ILinearMovement _linearMovement;
        
        private ISurfaceChecker _surfaceChecker;
        private IInputReader _inputReader;

        private void Awake()
        {
            _jumpBallisticsData = ConfigLoader.Create<BallisticsData>("Player/JumpData/BallisticsData.json");
            _jumpSpeedData = ConfigLoader.Create<SpeedData>("Player/JumpData/SpeedData.json");
            
            
            
            //_idleState = new IdleState(_body);
            //_idleStateCondition = new IdleStateCondition(_groundContactData);
            //_idleStateContext = new StateContext(_idleState, _idleStateCondition, _transitions);

            //_dashState = new DashState(_body, _linearMovement, _directionData, _dashSpeedData.Value);
            //_dashStateCondition = new DashStateCondition(_dashAction);
            //_dashStateContext = new StateContext(_dashState, _dashStateCondition, _transitions);

            //_fallState = new FallState(_body, _linearMovement, _gravityAffected, _gravityData, _directionData, _speedData);
            
            
        }
        
        
        
        
    }
}

























// just for see cursor on middle of my monitor