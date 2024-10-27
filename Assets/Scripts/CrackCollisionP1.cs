using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CrackCollisionP1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
    }
}

