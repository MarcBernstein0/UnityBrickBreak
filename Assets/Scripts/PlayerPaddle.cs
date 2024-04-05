using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            // Move up
            _direction = Vector2.left;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
           // Move down
            _direction = Vector2.right;
        } else {
            // Don't move
            _direction = Vector2.zero;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) {
            _rigidBody.AddForce(_direction * this.speed);
        }
    }
}
