using System;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    private const string EnemyTag = "Block";

    public Action OnEnemyCollision;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy == null) return;
        OnEnemyCollision?.Invoke();
        enemy.Destroy();
    }
}
