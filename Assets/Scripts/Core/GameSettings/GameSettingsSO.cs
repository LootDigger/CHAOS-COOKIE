using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObject/GameSettings")]
public class GameSettingsSO : ScriptableObject
{
    [SerializeField] 
    private GameSettings _gameSettings;
    public GameSettings GameSettings => _gameSettings;
}
