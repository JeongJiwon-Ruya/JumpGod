using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBlock : Block
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charactor"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.25f;
        }
    }
}
