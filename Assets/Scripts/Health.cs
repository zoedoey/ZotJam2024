using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadSceneAsync("End Game Scene");
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
                
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

    }

}
