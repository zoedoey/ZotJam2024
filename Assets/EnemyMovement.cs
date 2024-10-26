using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Rigidbody2D enemyRb;

    void FixedUpdate()
    {
        Vector2 dirToPlayer = rb.position - enemyRb.position;
        dirToPlayer.Normalize();
        Vector2 reflectedVector = Vector2.Reflect(rb.GetComponent<Rigidbody2D>().velocity, dirToPlayer);
        enemyRb.velocity = reflectedVector;
    }
}
