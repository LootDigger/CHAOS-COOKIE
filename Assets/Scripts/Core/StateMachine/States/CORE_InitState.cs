using CORE.UI;
using Patterns.AbstractStateMachine;
using UnityEngine;

public class CORE_InitState : MonoBehaviour, IState
{
    [SerializeField]
    private GameBootTrigger _gameBootManager;
    
    [SerializeField]
    private UIManager _uiManager;
    public StateMachine StateMachine { get; set; }
    
    public void EnterState()
    {
        SubscribeEvents();
        _uiManager.ShowScreen<WelcomeScreen>();
    }

    public void ExitState()
    {
        UnsubscribeEvents();
    }

    public void UpdateState()
    {
        _gameBootManager.UpdateManager();
    }

    private void SubscribeEvents()
    {
        _gameBootManager.OnGameBootRequested += OnGameBootRequested;
    }
    
    private void UnsubscribeEvents()
    {
        _gameBootManager.OnGameBootRequested += OnGameBootRequested;
    }

    private void OnGameBootRequested()
    {
        StateMachine.SetState<CORE_GameResetState>();
    }
}
