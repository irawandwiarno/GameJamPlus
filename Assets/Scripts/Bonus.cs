using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Prefeb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.Sleep();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.WakeUp();

        if (collision.gameObject.CompareTag("rocket"))
        {
            collision.gameObject.GetComponent<Rocket>().setBonus(Prefeb);
            Destroy(gameObject);
        }
    }

}
