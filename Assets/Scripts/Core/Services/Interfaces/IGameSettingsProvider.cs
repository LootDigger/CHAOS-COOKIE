using System;

public interface IGameSettingsProvider
{
    public GameSettings Settings { get; set; }
}

[Serializable]
public struct GameSettings
{
    public int ADPauseDuration;
    public int ADTriggerScoreLimitShift;
    public float EnemySpawnRateDelay;
}
