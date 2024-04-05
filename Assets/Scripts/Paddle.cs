using UnityEngine;

public class Paddle : MonoBehaviour
{

    protected Rigidbody2D _rigidBody;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Awake() 
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
}