using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour 
{
    bool isMove = false;
    public float movementSpeed = 0f;

    public void SetIsMove(bool value)
    {
        isMove = value;
    }
    void FixedUpdate()
    {
        if (isMove)
        {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isMove = false;
        }
    }
}
