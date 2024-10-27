using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLife = 1f;
    public float bulletSpeed = 1f;
    public float rotation = 0f;
    public float timer = 0f;
    public Vector2 spawnPoint;
    public Rigidbody2D rb;

    // Code tutorial from Sidereum Games
    void Start()
    {
        rb.velocity = new Vector2(0, -1 * bulletSpeed).RotatedBy(rotation);
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }
    
    void Update()
    {
        if (timer > bulletLife)
        {
            Destroy(this.gameObject);
        }

        timer += Time.deltaTime;
        
    }
}
