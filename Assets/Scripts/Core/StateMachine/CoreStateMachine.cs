using System;
using Patterns.AbstractStateMachine;
using UnityEngine;

namespace CORE.GameStates
{
    public class CoreStateMachine : StateMachine
    {
        [SerializeField]
        private CORE_InitState _initState;
        
        [SerializeField]
        private CORE_GameplayState _gameplayState;
        
        [SerializeField]
        private CORE_PauseState _pauseState;
        
        [SerializeField]
        private CORE_GameOverState _gameOverState;
        
        [SerializeField]
        private CORE_GameResetState _restartState;
        
        public void InitStateMachine()
        {
             RegisterState(_initState);
             RegisterState(_gameplayState);
             RegisterState(_pauseState);
             RegisterState(_gameOverState);
             RegisterState(_restartState);
        }

        private void Update()
        {
            UpdateCurrentState();
        }
    }
}