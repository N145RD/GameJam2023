using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    
    public void Starting()
    {
        Debug.Log("Next Scene");
        SceneManager.LoadScene("MainScene");
    }

    public void Quit()
    {
        Debug.Log("Leaving");
        Application.Quit();
    }

    public void Pausing()
    {
        _pauseMenu.SetActive(true);
    }

    public void StopPause()
    {
        _pauseMenu.SetActive(false);
    }

    public void MainMenuBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}   
