using System;
using Interfaces.FiniteStateMachine;
using UnityEngine;

namespace Components.FiniteStateMachine
{
    public class StateTransitions : MonoBehaviour, IStateTransitions
    {
        [SerializeField] private Component[] nextStatesOnExit;
        [SerializeField] private Component[] nextStatesOnInput;
        [SerializeField] private Component[] nextStatesWhileProcess;
        public IStateContext[] NextStatesOnExit { get; set; }
        public IStateContext[] NextStatesOnInput { get; set; }
        public IStateContext[] NextStatesWhileProcess { get; set; }

        private void OnValidate()
        {
            if (nextStatesOnExit is IStateContext[] targetOnExit) 
                NextStatesOnExit = targetOnExit;
            if (nextStatesOnInput is IStateContext[] targetOnInput) 
                NextStatesOnInput = targetOnInput;
            if (nextStatesWhileProcess is IStateContext[] targetWhileProcess) 
                NextStatesWhileProcess = targetWhileProcess;
        }
    }
}