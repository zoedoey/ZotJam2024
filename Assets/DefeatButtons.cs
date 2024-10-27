using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatButtons : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu 2");
    }
    public void Restart()
    {
        SceneManager.LoadSceneAsync("GamePlay Scene");
    }
}
