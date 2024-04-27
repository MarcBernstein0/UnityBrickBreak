using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int _numLives = 3;
    public int NumLives
    {
        get { return _numLives; }
    }
    public Ball ball;
    public Text lives;

    void Awake()
    {
        Score.score = 0;
    }
    public void DeathAndReset()
    {
        _numLives--;
        if (_numLives <= 0)
        {
            Debug.Log("Game end");
            Time.timeScale = 0f;
        }
        Debug.Log(_numLives);
        lives.text = "Lives: " + _numLives.ToString();

        ball.ResetBall();
    }

    public void ResetGame()
    {
        _numLives = 3;
        ball.ResetBall();
    }
}
