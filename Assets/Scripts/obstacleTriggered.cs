using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTriggered : MonoBehaviour
{
    public Rigidbody2D rb;
    bool isTriggered = false;
    public void SetIsTriggered(bool value)
    {
        isTriggered = value;
    }
    public void SetBodyStatic(Rigidbody2D rb)
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
    private Vector2 RandomVector(float min, float max)
    {
        var x = Random.Range(min, max);
        var y = Random.Range(min, max);
        return new Vector2(x, y);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; //setting gravity scale ke 0
    }
    void FixedUpdate()
    {
        if (isTriggered)
        {
                rb = GetComponent<Rigidbody2D>();
                rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            rb = GetComponent<Rigidbody2D>();
            rb.isKinematic = false;
            rb.velocity = RandomVector(-5f, 5f);
        }
    }
}

