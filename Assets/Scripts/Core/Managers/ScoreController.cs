using CORE.UI;
using Patterns.ServiceLocator;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private UIManager _uiManager;
    
    private IGameSaveProvider _gameSaveProvider;
    
    public Score CurrentScore { get; private set; }

    private void Awake()
    {
        CurrentScore = new Score();
    }

    private void Start()
    {
        SubscribeModelEvents();
        _gameSaveProvider = ServiceLocator.GetService<IGameSaveProvider>();
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

    public void SaveGameToSlot(int slotIndex)
    {
        _gameSaveProvider.SaveCurrentData(new GameSaveData()
        {
            _bestScore = CurrentScore.Value
        },slotIndex);
    }
    
    public void LoadGameSaveFromSlot(int slotIndex)
    {
        var gameSaveData = _gameSaveProvider.GetSave(slotIndex);
        Debug.Log("SLOT: " + slotIndex + "; Value == " + gameSaveData._bestScore);
    }
}
