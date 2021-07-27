using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnCubs : MonoBehaviour
{
    [SerializeField] private GameObject[] cubeToSpawn;
    [SerializeField] private Transform _transform;

    [SerializeField] private GameManager _gameManager;
    
    private int _randomInt;

    private int _randomScore;

    private void Awake()
    {
        _randomScore = Random.Range(5, 8);
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _randomScore; i++)
        {
            SpawnCube();
        }
    }

    public void SpawnCube()
    {
        var x = Random.Range(-4, 4);

        _randomInt = Random.Range(0, cubeToSpawn.Length);
        Instantiate(cubeToSpawn[_randomInt], new Vector3(x, _transform.position.y + 1, _transform.position.z), _transform.rotation);
        
        _gameManager.Cubs.Add(this.gameObject);
    }
}
