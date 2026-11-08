using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractStateMachine
{
    public abstract class StateMachine : MonoBehaviour
    {
        private Dictionary<Type, IState> _states = new();
        private IState _currentState;
        private IState _previousState;

        public IState CurrentState => _currentState;
        public IState PreviousState => _previousState;

        public void RegisterState(IState state)
        {
            _states.Add(state.GetType(), state);
            state.StateMachine = this;
        }

        public void SetState<TState>(bool debugSetState = false) where TState : IState
        {
            SetState(_states[typeof(TState)], debugSetState);
        }

        public virtual void UpdateCurrentState()
        {
            if(_currentState == null) return;
            _currentState.UpdateState();
        }

        private void SetState(IState state, bool debugSetState = false)
        {
            if (debugSetState)
                Debug.Log("SetState: " + state.GetType().Name);

            if (_currentState != null)
            {
                _currentState.ExitState();
                _previousState = _currentState;
            }

            _currentState = state;
            _currentState.EnterState();
        }
    }
}
