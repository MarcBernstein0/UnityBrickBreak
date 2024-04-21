using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    public Vector2 start_pos = new Vector2(0.0f, -1.5f);
    private Rigidbody2D _rigidBody;

    void Awake() 
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rigidBody.position = start_pos;
        _rigidBody.velocity = Vector2.zero;
    }

  
    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
        StartCoroutine(DelayStart(1));
    }

    public IEnumerator DelayStart(float seconds) 
    {
        yield return new WaitForSeconds(seconds);

        AddStartingForce();
    }

    void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.transform.CompareTag("Brick")) {
            Destroy(coll.gameObject);
        }
        Debug.Log("Ball has hit paddle" + coll.transform.tag);
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? Random.Range(-0.5f, -1.0f) :
                                        Random.Range(0.5f, 1.0f);
        float y = -1.0f;
        Vector2 direction = new Vector2(x, y);
        _rigidBody.AddForce(direction * this.speed);
    }

}
