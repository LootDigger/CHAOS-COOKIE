using CORE.GameStates;
using Patterns.ServiceLocator;
using UnityEngine;

public class PlayerDamageController : MonoBehaviour
{
    private CoreStateMachine _coreStateMachine;
    
    void Start()
    {
        _coreStateMachine = ServiceLocator.GetService<CoreStateMachine>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy == null) return;
        _coreStateMachine.SetState<CORE_GameOverState>();
    }
}
