using System;
using CORE.UI;
using Patterns.AbstractStateMachine;
using UnityEngine;

public class CORE_GameplayState : MonoBehaviour, IState
{
    [SerializeField]
    private CakeSpawner _cakeSpawner;
    
    [SerializeField]
    private PlayerMovement _playerMovement;
    
    [SerializeField]
    private UIManager _uiManager;
    
    public StateMachine StateMachine { get; set; }
    
    
    public void EnterState()
    {
         _cakeSpawner.StartSpawningRoutine();
         _playerMovement.SetMovementActivity(true);
         _uiManager.ShowScreen<GameplayScreen>();
    }

    public void ExitState()
    {
        _cakeSpawner.StopSpawningRoutine();
         _playerMovement.SetMovementActivity(false);
    }

    public void UpdateState()
    {
    }
}
