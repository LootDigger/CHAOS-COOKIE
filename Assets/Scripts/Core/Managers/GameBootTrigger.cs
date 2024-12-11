using System;
using UnityEngine;

public class GameBootTrigger : MonoBehaviour
{
    public Action OnGameBootRequested;

    public void UpdateManager()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnGameBootRequested?.Invoke();
        }
    }
}
