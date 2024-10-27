using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackSpawn : MonoBehaviour
{
    public float crackLife = 5f;
    public float timer = 0f;
    public Vector2 spawnPoint;
    public SpriteRenderer renderer;
    public Sprite greyCrack;
    public Sprite redCrack;




    Vector2 Movement(float timer)
    {
        float x = UnityEngine.Random.Range(-8f, 8f); // Adjust range as needed
        float y = UnityEngine.Random.Range(1f, 4f); // Adjust range as needed

        return new Vector2(x, y);
    }

    // Code tutorial from Sidereum Games
    void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
        transform.position = Movement(timer);

    }

    //float x = spawnPoint.x + Random.Range(-2f, 2f); // Adjust range as needed
    //float y = spawnPoint.y + Random.Range(-2f, 2f); // Adjust range as needed


    void Update()
    {
        if (timer == 1.5f)
        {
            renderer.sprite = greyCrack;

        }
        //if (timer > f)
        //{
        //    renderer.sprite = redCrack;
        //}
        if (timer > crackLife)
        {
            //Destroy(this.gameObject);
            renderer.sprite = redCrack;
        }

        timer += Time.deltaTime;


    }

}
