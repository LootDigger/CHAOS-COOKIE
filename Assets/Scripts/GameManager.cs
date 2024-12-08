using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject block;

    public GameObject welcomeScreen;
    public TextMeshProUGUI scoreText;

    public float maxX;
    public Transform spawnPoint;
    public float spawnRate;

    bool gameStarted = false;
    private int scoreValue = 0;

    void Update()
    {
        welcomeScreen.SetActive(!gameStarted);
        scoreText.enabled = gameStarted;
        
        if(Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();
            gameStarted = true;
            scoreValue = 0;
        }
        
    }

    public void incrementAndUpdateScore()
    {
        scoreValue++;
        scoreText.text = scoreValue.ToString();
    }

    private void StartSpawning()
    {
        float spawnDelayInSeconds = 0.5f;
        InvokeRepeating("SpawnBlock", spawnDelayInSeconds, spawnRate);
    }

    private void SpawnBlock()
    {
        Vector3 spawnPosition = spawnPoint.position;
        spawnPosition.x = Random.Range(-maxX, maxX);

        Instantiate(block, spawnPosition, Quaternion.identity);
    }

}
