using System;
using CORE.UI;
using Patterns.AbstractStateMachine;
using UnityEngine;

public class CORE_PauseState : MonoBehaviour, IState
{
    [SerializeField]
    private UIManager _uiManager;

    [SerializeField] 
    private ADPauseController _pauseController;
    
    public StateMachine StateMachine { get; set; }
    
    public void EnterState()
    {
        _uiManager.ShowScreen<ADPauseScreen>();
        _pauseController.OnPauseStateEnter();
        SetTimeScale(0f);
    }

    public void ExitState()
    {
        SetTimeScale(1f);
    }

    public void UpdateState()
    {
    }

    private void SetTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
