using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public SpriteRenderer renderer;
    public Sprite left;
    public Sprite right;
    public Sprite front;
    public Sprite back;
    public Camera camera;

    //renderer.sprite = left
    //


    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // * Time.deltaTime * moveSpeed
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
        if (movement.x < 0)
        {
            renderer.sprite = left;

        }
        if (movement.x > 0)
        {
            renderer.sprite = right;
        }
        if (movement.x == 0 && movement.y == 0)
        {
            renderer.sprite = front;
        }
        if (movement.y > 0)
        {
            renderer.sprite = back;
            
        }
        if (movement.y < 0)
        {
            renderer.sprite = front;
        }
        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        PreventPlayerFromGoingOffScreen();

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    public Transform BulletSpawnPoint;
    public GameObject bullet;
    public Vector2 up = new Vector2(0, 1);
    public float force = 10f;

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().velocity = movement.normalized * force;
        if (movement.x == 0 && movement.y == 0)
        {
            // Need to get this to work, should shoot up when player isn't moving
            newBullet.GetComponent<Rigidbody2D>().velocity = up * force;
        }
        Destroy(newBullet, 3);
    }

    void PreventPlayerFromGoingOffScreen()
    {
        Vector2 screenPosition = camera.WorldToScreenPoint(transform.position);

        if (screenPosition.x < 0 && rb.velocity.x < 0 || (screenPosition.x > camera.pixelWidth && rb.velocity.x > 0)) 
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
