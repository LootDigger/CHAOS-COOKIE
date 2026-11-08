using CORE.GameStates;
using CORE.UI;
using Patterns.ServiceLocator;
using UnityEngine;

public class ADPauseController : MonoBehaviour
{
    [SerializeField] 
    private UIManager _uiManager;
    
    private Timer _timer;
    private CoreStateMachine _stateMachine;
    private IGameSettingsProvider _gameSettingsProvider;

    private void Start()
    {
        GetServices();
        _timer = new Timer(_gameSettingsProvider.Settings.ADPauseDuration);
        SubscribeEvents();
    }

    private void Update()
    {
        _timer.UpdateTimer();
    }

    private void OnDestroy()
    {
        UnsubscribeEvents();
    }

    private void GetServices()
    {
        _gameSettingsProvider = ServiceLocator.GetService<IGameSettingsProvider>();
        _stateMachine = ServiceLocator.GetService<CoreStateMachine>();
    }

    private void SubscribeEvents()
    {
        _timer.OnSecondPassed += TimerOnOnSecondPassed;
        _timer.OnTimerStarted += TimerOnOnTimerStarted;
    }

    private void UnsubscribeEvents()
    {
        _timer.OnSecondPassed -= TimerOnOnSecondPassed;
        _timer.OnTimerStarted -= TimerOnOnTimerStarted;
    }

    private void TimerOnOnSecondPassed(int countdownTime)
    {
        _uiManager.UpdatePauseTimerView(countdownTime);
        if (countdownTime > 0) return;
        ContinueGame();
    }
    
    private void TimerOnOnTimerStarted(int countdownTime)
    {
        _uiManager.UpdatePauseTimerView(countdownTime);
    }
    
    public void OnPauseStateEnter()
    {
        _timer.StartClock();
    }

    public void ContinueGame()
    {
        _timer.StopClock();
        _stateMachine.SetState<CORE_GameplayState>();
    }
}
