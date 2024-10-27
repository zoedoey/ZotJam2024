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

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= firingRate)
        {
            Fire();
            timer = 0;
        }
    }

    void Fire()
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().bulletSpeed = bulletSpeed;
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;

            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
