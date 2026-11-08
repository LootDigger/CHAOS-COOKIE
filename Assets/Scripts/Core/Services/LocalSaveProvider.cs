using UnityEngine;

public class LocalSaveProvider : IGameSaveProvider
{
    private const string SaveSlotKeyName = "SLOT-"; 
    
    public void SaveCurrentData(GameSaveData gameSaveData, int saveSlotIndex)
    {
       PlayerPrefs.SetString((SaveSlotKeyName + saveSlotIndex),JsonUtility.ToJson(gameSaveData));
    }

    public GameSaveData GetSave(int saveSlotIndex)
    {
        return JsonUtility.FromJson<GameSaveData>(PlayerPrefs.GetString(SaveSlotKeyName + saveSlotIndex));
    }
}
