using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnedBullet;
    public float bulletLife = 1f;
    public float bulletSpeed = 1f;
    public float firingRate = 1f;
    public float timer = 0f;

    // Code tutorial from Sidereum Games
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= firingRate)
        {
            timer = 0;
            int type = UnityEngine.Random.Range(0, 2);
            if (type == 0) //shotgun level 1
            {
                Fire(0);
                Fire(45);
                Fire(-45);
            }
            if (type == 1) //double small arrowhead
            {
                timer = -1;
                Fire(0, new Vector2(-4, 3));
                Fire(0, new Vector2(0, 2));
                Fire(0, new Vector2(4, 3));
                Fire(0, new Vector2(-4, 1));
                Fire(0);
                Fire(0, new Vector2(4, 1));
            }
            if (type == 2) //shotgun level 2
            {
                Fire(0);
                Fire(15);
                Fire(45);
                Fire(-15);
                Fire(-45);
            }
            if (type == 3) //shotgun level 3
            {
                Fire(0);
                Fire(15);
                Fire(30);
                Fire(45);
                Fire(-15);
                Fire(-30);
                Fire(-45);
            }
            if (type == 4) //shotgun level 1
            {
                Fire(0);
                Fire(45);
                Fire(-45);
            }
            if (type == 5) //shotgun level 1
            {
                Fire(0);
                Fire(45);
                Fire(-45);
            }
        }
    }

    void Fire(float rotation, Vector3 offset = default)
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position + offset, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().bulletSpeed = bulletSpeed;
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;
            spawnedBullet.GetComponent<Bullet>().rotation = rotation;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
