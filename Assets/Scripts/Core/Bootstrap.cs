using System;
using Patterns.ServiceLocator;
using UnityEngine;
using CORE.GameStates;

public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private CoreStateMachine _coreStateMachine;
    
    [SerializeField]
    private GameSettingsSO _gameSettingsSO;
    
    private void Awake()
    {
        InitServices();
        InitStateMachine();
    }

    private void Start()
    {
        _coreStateMachine.SetState<CORE_InitState>();
    }

    private void InitServices()
    {
        ServiceLocator.RegisterService(_coreStateMachine);
        ServiceLocator.RegisterService(new SceneLoader());
        
#if REMOTE_SETTINGS
        ServiceLocator.RegisterService<IGameSettingsProvider>(new RemoteSettingsProvider());
#else
        ServiceLocator.RegisterService<IGameSettingsProvider>(new LocalSettingsProvider(_gameSettingsSO));
#endif
    }

    private void InitStateMachine()
    {
        _coreStateMachine.InitStateMachine();
    }
}
