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

    // Code tutorial from Sidereum Games
    void Start()
    {
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {
        renderer.sprite = greyCrack;
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
