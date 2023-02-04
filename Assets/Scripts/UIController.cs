using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject playButton;

    void Start(){
        Time.timeScale = 0;
    }

    public void StartGame(){
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
