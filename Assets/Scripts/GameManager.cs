using CORE.GameStates;
using Patterns.ServiceLocator;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GroundCollider _groundCollider;

    [SerializeField]
    private ScoreController _scoreController;
    
    private CoreStateMachine _coreStateMachine;
    private ADScoreCounter _adScoreCounter;
    
    private void Start()
    {
        InitServices();
        SubscribeEvents();
        _adScoreCounter = new ADScoreCounter();
    }

    private void OnDestroy()
    {
        UnsubscribeEvents();
    }

    private void InitServices()
    {
        _coreStateMachine = ServiceLocator.GetService<CoreStateMachine>();
    }
    
    private void SubscribeEvents()
    {
        _scoreController.CurrentScore.OnModelChangedEvent += CurrentScoreOnOnModelChangedHandler;
        _groundCollider.OnEnemyCollision += OnEnemyCollisionHandler;
    }

    private void UnsubscribeEvents()
    {
        _scoreController.CurrentScore.OnModelChangedEvent -= CurrentScoreOnOnModelChangedHandler;
        _groundCollider.OnEnemyCollision -= OnEnemyCollisionHandler;
    }
    
    private void CurrentScoreOnOnModelChangedHandler(int scoreValue)
    {
        if (scoreValue < _adScoreCounter.ScoreLimit) return;
        _adScoreCounter.ShiftScoreLimit();
        _coreStateMachine.SetState<CORE_PauseState>();
    }
    
    private void OnEnemyCollisionHandler()
    {
        _scoreController.IncreaseGameScore();
    }
}
