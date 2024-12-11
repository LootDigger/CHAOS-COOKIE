using System.Collections;
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
    
    [SerializeField]
    private float _spawnRateDelay = 1f;

    private WaitForSeconds _waitYield;

    private void Awake()
    {
        _waitYield = new WaitForSeconds(_spawnRateDelay);
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
