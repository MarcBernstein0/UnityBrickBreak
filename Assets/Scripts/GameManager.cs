using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Ball ball;
    private int _numLives = 3;
    public int NumLives { 
        get { return _numLives; } 
    }

    public void DeathAndReset()
    {
        _numLives--;
        if (_numLives <= 0) {
            Debug.Log("Game end");
        }
        Debug.Log(_numLives);

        ball.ResetBall();
    }

    public void ResetGame()
    {
        _numLives = 3;
        ball.ResetBall();
    }
}
