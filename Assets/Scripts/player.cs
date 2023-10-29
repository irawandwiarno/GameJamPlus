using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; //setting gravity scale ke 0
    }
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //membuat variabel yang berisi koordinat posisi mouse
        rb.position = mousePosition; //membuat posisi objek mengikuti posisi mouse 
    }
}

    