using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTrigger : MonoBehaviour
{
    public ObstacleTriggered[] obstacle;
    private void OnTriggerEnter2D(Collider2D col)
    {
        foreach (var obstacle in obstacle)
        {
            if (col.gameObject.CompareTag("Rocket"))
            {
                obstacle.SetIsTriggered(true);
            }
        }
    }
}
