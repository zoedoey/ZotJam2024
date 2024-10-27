using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// implement the bullet speed increase
// also a win condition for the enemy hits

public class CrackCollisionP1 : MonoBehaviour
{
    public SpriteRenderer renderer;
    //public SpriteRenderer renderer2;
    public Sprite greyCrack;
    public Sprite redCrack;
    //public Sprite backCrack;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (renderer.sprite == redCrack)    /// don't destroy change to grey, add some more collisions!!
        {
            Destroy(this.gameObject);

        }
        //renderer2.sprite = backCrack;
    }
}

