using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRed: MonoBehaviour
{
    private GameManager _game;

    [SerializeField] private Rigidbody _rigidbody;

    private void Start()
    {
        _game = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedCube")
        {
            _game._scoreRed++;
            
            Destroy(this.gameObject);
            
            _game.Cubs.RemoveAt(0);
            
        }

        if (other.tag == "BlueCube")
        {
            
        }
    }

}
