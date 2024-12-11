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
    private int _scoreTarget;
    private readonly int _scoreValueDelta = 10;
    
    private void Start()
    {
        InitServices();
        SubscribeEvents();

        _scoreTarget = _scoreValueDelta;
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
        if (scoreValue >= _scoreTarget)
        {
            _coreStateMachine.SetState<CORE_PauseState>();
            _scoreTarget += _scoreValueDelta;
        }
    }
    
    private void OnEnemyCollisionHandler()
    {
        _scoreController.IncreaseGameScore();
    }
}
