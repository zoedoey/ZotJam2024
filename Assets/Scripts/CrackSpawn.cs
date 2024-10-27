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


    public GameObject spritePrefab;
    public float exclusionRadius = 10f; // Radius around the center to avoid

    public void SpawnSprite()
    {
        Vector2 spawnPosition;

        do
        {
            // Generate a random position within a defined area
            spawnPosition = new Vector2(UnityEngine.Random.Range(-10f, 10f), UnityEngine.Random.Range(-10f, 10f));
        }
        while (IsInExclusionZone(spawnPosition));

        // Instantiate the sprite at the valid position
        Instantiate(spritePrefab, spawnPosition, Quaternion.identity);
    }

    private bool IsInExclusionZone(Vector2 position)
    {
        // Check if the position is within the exclusion radius of the center
        return Vector2.Distance(position, Vector2.zero) < exclusionRadius; // Excludes positions within the exclusion radius from center
    }


    Vector2 Movement(float timer)
    {
        float x = UnityEngine.Random.Range(-6f, 6f); // Adjust range as needed
        float y = UnityEngine.Random.Range(-6f, 6f); // Adjust range as needed

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
