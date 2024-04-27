using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private bool _inPlay;
    private Rigidbody2D _rigidBody;
    public bool InPlay { set { _inPlay = value; } }
    public float Speed = 200.0f;
    // public Vector2 start_pos = new Vector2(0.0f, -1.5f);
    public Transform BallPosition;
    public Text score;




    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _inPlay = false;
    }

    public void ResetBall() 
    {
        _inPlay = false;
        _rigidBody.velocity = Vector2.zero;
    }

    void Update()
    {
        if (!_inPlay)
        {
            transform.position = BallPosition.position;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !_inPlay) {
            _inPlay = true;
            this.AddStartingForce();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.CompareTag("Brick"))
        {
            Score.score += 10;
            score.text = "Score: " + Score.score.ToString();
            Destroy(coll.gameObject);
        }
        Debug.Log("Ball has hit" + coll.gameObject.tag);
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? Random.Range(-0.5f, -1.0f) :
                                        Random.Range(0.5f, 1.0f);
        float y = 1.0f;
        Vector2 direction = new Vector2(x, y);
        _rigidBody.AddForce(direction * Speed);
    }

}
