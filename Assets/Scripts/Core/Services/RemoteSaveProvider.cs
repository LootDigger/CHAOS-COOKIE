using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteSaveProvider : IGameSaveProvider
{
    public void SaveCurrentData(GameSaveData gameSaveData, int saveSlotIndex)
    {
        // Here we can put some backend logic
    }

    public GameSaveData GetSave(int saveSlotIndex)
    {
        // Here we can put some backend logic
        return new GameSaveData()
        {
            _bestScore = 999
        };
    }
}
