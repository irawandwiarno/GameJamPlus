using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManagement : MonoBehaviour
{
    public GameObject PanelMainMenu;
    public GameObject PanelInfo;

    private void Start()
    {
        PanelInfo.SetActive(false);
    }
    public void startButton()
    {
       SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void infoButton()
    {
        PanelMainMenu.SetActive(false);
        PanelInfo.SetActive(true);
    }

    public void backButton()
    {
        PanelInfo.SetActive(false);
        PanelMainMenu.SetActive(true);
    }
}
