using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RockerController : MonoBehaviour
{
    bool isLaunch = true;
    public float movementSpeed = 0f;
    private Collider2D col;
    private void Start()
    {
        col = GetComponent<Collider2D>();
        col.isTrigger = true; //set collider menjadi trigger
    }
    void FixedUpdate()
    {
        if (isLaunch)
        {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("LoseScene", LoadSceneMode.Single);
        }
    }
}
