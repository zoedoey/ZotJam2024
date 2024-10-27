using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class crackCollision2 : MonoBehaviour
{
    public SpriteRenderer renderer;
    public Sprite greyCrack;
    public Sprite redCrack;

    //void OnCollisionEnter2D(Collision2D collider)
    //{
    //    if (collider.collider.CompareTag("Player"))
    //    {
    //        Debug.Log("Collided");
    //        Health.instance.health--;
    //        Destroy(gameObject);
    //    }
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            UnityEngine.Debug.Log("Collided");
            enemyHealth.instance.health--;
            //Destroy(gameObject);
        }
        if (renderer.sprite == redCrack)    /// don't destroy change to grey, add some more collisions!!
        {
            Destroy(this.gameObject);
        }
        
    }
}
