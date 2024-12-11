using System;
using Patterns.ServiceLocator;
using UnityEngine;
using CORE.GameStates;

public class Bootstrap : MonoBehaviour
{
    [SerializeField]
    private CoreStateMachine _coreStateMachine;
    
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
    }

    private void InitStateMachine()
    {
        _coreStateMachine.InitStateMachine();
    }
}
