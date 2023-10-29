using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))//"Rocket bisa diganti sesuai tag akan yang mentrigger finish
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Single);//"WinScene adalah nama scene untuk scene ketika roket sampai ke planet Mars
        }
    }
}
