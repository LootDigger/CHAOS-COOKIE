using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManagerObject").GetComponent<GameManager>();
    }

    void Update()
    {
        if(transform.position.y < -6f) {
            gameManager.incrementAndUpdateScore();
            Destroy(gameObject);
            
        }
    }
}
