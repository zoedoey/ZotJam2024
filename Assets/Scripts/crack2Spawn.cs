using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crack2Spawn : MonoBehaviour
{
    public float crackLife = 10f;
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


    void Update()
    {
        if (timer == 7.5f)
        {
            renderer.sprite = greyCrack;

        }
        if (timer > crackLife)
        {
            renderer.sprite = redCrack;
        }

        timer += Time.deltaTime;


    }

}
