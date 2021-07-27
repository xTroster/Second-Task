using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    
    public List<GameObject> Cubs => _cubs;

    [SerializeField] private Text _redText;
    [SerializeField] private Text _blueText;
    [SerializeField] private GameObject _restart;
    [SerializeField] private List<GameObject> _cubs;

    

    public int _scoreRed;
    public int _scoreBlue;
    private bool _isGameOver;
    // Start is called before the first frame update
    void Start()
    {

        _restart.SetActive(false);
        
        _scoreRed = 0;
        _scoreBlue = 0;

        _blueText.text = _scoreBlue.ToString();
        _redText.text = _scoreRed.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if (_isGameOver)
        {
            return;
        }
        
        if (_cubs.Count == 0)
        {
            GameRestart();
            _isGameOver = true;
        }
        
        
        _blueText.text = _scoreBlue.ToString();
        _redText.text = _scoreRed.ToString();
        
    }

    private void GameRestart()
    {
        _restart.SetActive(true);
    }
}
