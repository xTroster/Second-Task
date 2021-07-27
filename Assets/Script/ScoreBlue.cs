using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBlue : MonoBehaviour
{
    private GameManager _game;

    [SerializeField] private DragAndDrop _dragAnd;
    private void Start()
    {
        _game = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BlueCube")
        {
            _game._scoreBlue++;
            
            Destroy(this.gameObject);
            
            _game.Cubs.RemoveAt(0);
        }
        
        if (other.tag == "RedCube")
        {
            
        }

        
    }
}
