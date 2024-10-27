using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickAnywhere : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("GamePlay Scene");
    }
}
