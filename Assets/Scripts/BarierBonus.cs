using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarierBonus : MonoBehaviour
{
    public GameObject Angkor;
    public float duration;
    private int flag = 0;

    private void Update()
    {
        Debug.Log(Angkor);
        Debug.Log("update");

        if (Angkor != null)
        {
            Debug.Log("tes");
            transform.position = Angkor.transform.position;
        }
        if (flag == 0)
        {
            setDestroy();
            flag = 1;
        }
    }

    public void setAngkor(GameObject AngkorObject, float duration)
    {
        Debug.Log(AngkorObject.transform.position.y);

        this.Angkor = AngkorObject;
        this.duration = duration;
    }

    private void setDestroy()
    {
        Destroy(gameObject, duration);
    }

}
