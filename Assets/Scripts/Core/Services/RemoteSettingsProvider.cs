using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteSettingsProvider : IGameSettingsProvider
{
    public GameSettings Settings { get; set; }
    
    public RemoteSettingsProvider()
    {
        Settings = GetRemoteGameSettings();
    }

    private GameSettings GetRemoteGameSettings()
    {
        return new GameSettings()
        {
            ADPauseDuration = 10,
            ADTriggerScoreLimitShift = 5,
            EnemySpawnRateDelay = 1.5f
        };
    }
}
