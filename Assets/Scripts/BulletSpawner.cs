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
    public float timer2 = 0f;

    [SerializeField] private AudioClip shotSoundClip;
    private AudioSource audioSource;
    public int nextpatterntype;
    // Code tutorial from Sidereum Games
    // Update is called once per frame
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer >= firingRate)
        {
            timer = 0;
            int type = nextpatterntype;
            if (type == 0) //shotgun level 1
            {
                Fire(0);
                Fire(45);
                Fire(-45);
                nextpatterntype = 3;
            }
            if (type == 1) //double small arrowhead
            {
                timer = 0.3f;
                Fire(0, new Vector2(3, 0));
                Fire(0, new Vector2(-3, 0));
                Fire(0);
                nextpatterntype = 2;
            }
            if (type == 2) //double small arrowhead pt2
            {
                Fire(0, new Vector2(1.5f, 0));
                Fire(0, new Vector2(-1.5f, 0));
                Fire(30);
                Fire(-30);
                nextpatterntype = UnityEngine.Random.Range(0, 7);
            }
            if (type == 3) //shotgun level 2
            {
                Fire(0);
                Fire(15);
                Fire(45);
                Fire(-15);
                Fire(-45);
                nextpatterntype = 4;
            }
            if (type == 4) //shotgun level 3
            {
                Fire(0);
                Fire(15);
                Fire(30);
                Fire(45);
                Fire(-15);
                Fire(-30);
                Fire(-45);
                nextpatterntype = UnityEngine.Random.Range(0, 7);
            }
            if (type == 5) //row of five
            {
                timer = 0.2f;
                Fire(0);
                Fire(0, new Vector2(2, 0));
                Fire(0, new Vector2(-2, 0));
                Fire(0, new Vector2(4, 0));
                Fire(0, new Vector2(-4, 0));
                nextpatterntype = 6;
            }
            if (type == 6) //row of four
            {
                Fire(0, new Vector2(1, 0));
                Fire(0, new Vector2(-1, 0));
                Fire(0, new Vector2(3, 0));
                Fire(0, new Vector2(-3, 0));
                nextpatterntype = UnityEngine.Random.Range(0, 7);
            }
            Fire(0, new Vector2(6, 0));
            Fire(0, new Vector2(-6, 0));
            if (timer == 6)
            {
                Destroy(gameObject);
            }
        }
    }

    void Fire(float rotation, Vector3 offset = default)
    {
        if (bullet)
        {
            audioSource.clip = shotSoundClip;
            audioSource.PlayOneShot(shotSoundClip);
    
            spawnedBullet = Instantiate(bullet, transform.position + offset, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().bulletSpeed = bulletSpeed * (1 + timer2/120);
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;
            spawnedBullet.GetComponent<Bullet>().rotation = rotation;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
