using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Scenes/main");
    }

    public void LoadMenu()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }

    
}
