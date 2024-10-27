using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLife = 1f;
    public float bulletSpeed = 1f;
    public float rotation = 0f;
    public float timer = 0f;
    public GameObject health;
    public Vector2 spawnPoint;
    public Rigidbody2D rb;
    public GameObject bullet;
    public int playerHealth;

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
        transform.rotation = Quaternion.identity;
        transform.Rotate(new Vector3(0, 0, Mathf.Atan2(rb.velocity.y, rb.velocity.x)) * Mathf.Rad2Deg);
        timer += Time.deltaTime;
        
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.collider.CompareTag("Player"))
        {
            Debug.Log("Collided");
            Health.instance.health--;
            Destroy(gameObject);
        }
    }
}
