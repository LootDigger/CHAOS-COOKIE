using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameSaveProvider
{
    public void SaveCurrentData(GameSaveData gameSaveData, int saveSlotIndex);
    public GameSaveData GetSave(int saveSlotIndex);
}

[Serializable]
public struct GameSaveData
{
    public int _bestScore;
}
