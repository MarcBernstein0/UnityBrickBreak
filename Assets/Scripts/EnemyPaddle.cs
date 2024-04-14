using UnityEngine;

public class EnemyPaddle : Paddle
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll) 
    {
        Destroy(gameObject);
        Debug.Log("Ball has hit paddle");
    }
}
