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
            int type = UnityEngine.Random.Range(0, 1);
            if (type == 0)
            {
                Fire(0);
                Fire(45);
                Fire(-45);
            }
            timer = 0;
        }
    }

    void Fire(float rotation)
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().bulletSpeed = bulletSpeed;
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;
            spawnedBullet.GetComponent<Bullet>().rotation = rotation;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
