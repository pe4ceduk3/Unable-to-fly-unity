using System;
using Interfaces;
using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    [Serializable]
    public class StateContext : MonoBehaviour, IStateContext
    {
        [SerializeField] private SerializeInterface<IState> state;
        [SerializeField] private SerializeInterface<IStateCondition> condition;
        [SerializeField] private SerializeInterface<IStateTransitions> transition;
        public IState State
        { 
            get => state.Value; 
            set => state = new SerializeInterface<IState>(value as UnityEngine.Object); 
        }
        public IStateCondition Condition
        {
            get => condition.Value;
            set => condition = new SerializeInterface<IStateCondition>(value as UnityEngine.Object);
        }
        public IStateTransitions Transitions
        {
            get => transition.Value;
            set => transition = new SerializeInterface<IStateTransitions>(value as UnityEngine.Object);
        }

    }
}