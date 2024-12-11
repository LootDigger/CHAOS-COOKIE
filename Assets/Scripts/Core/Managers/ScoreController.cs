using CORE.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private UIManager _uiManager;
    
    public Score CurrentScore { get; private set; }

    private void Awake()
    {
        CurrentScore = new Score();
    }

    private void Start()
    {
        SubscribeModelEvents();
    }

    private void OnDestroy()
    {
        UnsubscribeModelEvents();
    }

    private void SubscribeModelEvents()
    {
        CurrentScore.OnModelChangedEvent += CurrentScoreChangedEvent;
    }
    
    private void UnsubscribeModelEvents()
    {
        CurrentScore.OnModelChangedEvent -= CurrentScoreChangedEvent;
    }

    private void CurrentScoreChangedEvent(int currentScore)
    {
        _uiManager.UpdateScoreView(currentScore);
    }
    
    public void IncreaseGameScore()
    {
        CurrentScore.Value++;
    }
    
    public void ResetGameScore()
    {
        CurrentScore.Value = 0;
    }
}
