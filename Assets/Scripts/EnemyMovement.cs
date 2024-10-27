using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NOTES:
// detect edge of screen

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public SpriteRenderer renderer;
    public Sprite left;
    public Sprite right;
    public Sprite front;
    public Sprite back;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // INVERT UP AND DOWN

    // Update is called once per frame
    void Update() // updates the players movement
    {
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
            renderer.sprite = front;

        }
        if (movement.y < 0)
        {
            renderer.sprite = back;
        }
        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement = Vector2.down;      // Move down when Up Arrow is pressed
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement = Vector2.up;        // Move up when Down Arrow is pressed
        }

    }
    void FixedUpdate() //fixes the update in terms of time/speed
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    //Bullet mechanics
    public Transform BulletSpawnPoint;
    public GameObject bullet;
    public Vector2 up = new Vector2(0, 1);
    public float force = 10f;
    public int counter;

    void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
        newBullet.GetComponent<Rigidbody2D>().velocity = movement.normalized * force;
        if (movement.x == 0 && movement.y == 0)
        {
            newBullet.GetComponent<Rigidbody2D>().velocity = up * force;
        }
        Destroy(newBullet, 3);
    }
}

