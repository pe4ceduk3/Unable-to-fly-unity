using System;
using Interfaces;
using Interfaces.FiniteStateMachine;
using System.Linq;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    [Serializable]
    public class StateTransitions : MonoBehaviour, IStateTransitions
    {
        [SerializeField] private SerializeInterface<IStateContext>[] nextStatesOnExit;
        [SerializeField] private SerializeInterface<IStateContext>[] nextStatesOnInput;
        [SerializeField] private SerializeInterface<IStateContext>[] nextStatesWhileProcess;
        
        public IStateContext[] NextStatesOnExit
        {
            get => nextStatesOnExit?.Select(s => s.Value).ToArray();
            set => nextStatesOnExit = value?.Select(v => new SerializeInterface<IStateContext>(v as UnityEngine.Object)).ToArray();
        }
        public IStateContext[] NextStatesOnInput
        {
            get => nextStatesOnInput?.Select(s => s.Value).ToArray();
            set => nextStatesOnInput = value?.Select(v => new SerializeInterface<IStateContext>(v as UnityEngine.Object)).ToArray();
        }
        public IStateContext[] NextStatesWhileProcess
        {
            get => nextStatesWhileProcess?.Select(s => s.Value).ToArray();
            set => nextStatesWhileProcess = value?.Select(v => new SerializeInterface<IStateContext>(v as UnityEngine.Object)).ToArray();
        }
    }
}