using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalSettingsProvider : IGameSettingsProvider
{
    public LocalSettingsProvider(GameSettingsSO settingsContainer)
    {
        Settings = settingsContainer.GameSettings;
    }

    public GameSettings Settings { get; set; }
}
