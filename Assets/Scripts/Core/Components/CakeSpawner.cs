using System;
using System.Collections;
using Patterns.ServiceLocator;
using UnityEngine;
using Random = UnityEngine.Random;

public class CakeSpawner : MonoBehaviour
{    
    [SerializeField]
    private GameObject _block;
    
    [SerializeField]
    private Transform _spawnPoint;
    
    [SerializeField]
    public float _spawnBiasX = 2.25f;
    
    private WaitForSeconds _waitYield;
    private IGameSettingsProvider _gameSettingsProvider;

    private void Start()
    {
        _gameSettingsProvider = ServiceLocator.GetService<IGameSettingsProvider>();
        _waitYield = new WaitForSeconds(_gameSettingsProvider.Settings.EnemySpawnRateDelay);
    }

    public void StartSpawningRoutine()
    {
        StartCoroutine(SpawnRoutine());
    }
    
    public void StopSpawningRoutine()
    {
        StopAllCoroutines();
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return _waitYield;
            SpawnBlock();
        }
    }

    private void SpawnBlock()
    {
        Vector3 spawnPosition = _spawnPoint.position;
        spawnPosition.x = Random.Range(-_spawnBiasX, _spawnBiasX);
        Instantiate(_block, spawnPosition, Quaternion.identity);
    }
}
