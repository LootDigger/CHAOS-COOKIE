using Patterns.AbstractStateMachine;
using UnityEngine;

public class CORE_GameResetState : MonoBehaviour, IState
{
    [SerializeField]
    private ScoreController _scoreController;
    
    [SerializeField]
    private PlayerMovement _playerMovement;
    public StateMachine StateMachine { get; set; }
    
    public void EnterState()
    {
        _playerMovement.ResetPosition();
        _scoreController.ResetGameScore();
        StateMachine.SetState<CORE_GameplayState>();
    }

    public void ExitState()
    {
    }

    public void UpdateState()
    {
    }
}
