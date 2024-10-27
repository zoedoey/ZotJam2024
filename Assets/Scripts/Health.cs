using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;

// I think use the collider classes in here where like if collide then i-= 1 and if zero, then we disable sprite renderer

public class Health : MonoBehaviour
{
    public static Health instance;
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    void Update()
    {
        instance = this;

        if (health < 1)
        {
            SceneManager.LoadSceneAsync("Defeat Screen");
        }

    }

}
