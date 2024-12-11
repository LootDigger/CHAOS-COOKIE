using System.Collections.Generic;
using UnityEngine;

namespace CORE.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField]
        private WelcomeScreen _welcomeScreen;
        
        [SerializeField]
        private GameplayScreen _gameplayScreen;
        
        [SerializeField]
        private ADPauseScreen _adPauseScreen;
        
        [SerializeField]
        private GameOverScreen _gameOverScreen;
        
        private AbstractScreen _currentAbstractScreen;
        private List<AbstractScreen> _uiScreens;

        private void Awake()
        {
            InitScreens();
        }

        private void InitScreens()
        {
            _uiScreens = new List<AbstractScreen>()
            {
                _welcomeScreen,
                _gameplayScreen,
                _adPauseScreen,
                _gameOverScreen
            };
        }

        private void Show(AbstractScreen abstractScreen, bool addictive = false)
        {
            if (abstractScreen == null) return;

            if (_currentAbstractScreen != null && !addictive)
            {
                _currentAbstractScreen.HideInstantly();
            }

            abstractScreen.ShowInstantly();
            _currentAbstractScreen = abstractScreen;
        }

        public void ShowScreen<T>( bool addictive = false) where T: AbstractScreen
        {
            foreach (var screen in _uiScreens)
            {
                if (screen is T)
                {
                    Show(screen,addictive);
                    break;
                }
            }
        }
        
        public void UpdateScoreView(int newScore)
        {
            _gameplayScreen.UpdateScoreView(newScore);
        }

        public void UpdatePauseTimerView(int countdownTime)
        {
            _adPauseScreen.UpdatePauseTimerView(countdownTime);
        }
    }
}