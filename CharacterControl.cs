using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{

    Rigidbody2D rb2d;
    Animator anim;
    Vector3 vel;
    Vector3 currentJumpForce;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {

            anim.SetBool("Jump",true);
            anim.SetBool("Idle", false);
            anim.SetBool("Charge", false);
            vel = SetToBounce(rb2d.velocity); Debug.Log(rb2d.velocity);
            rb2d.AddForce(vel);

        }

        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("Idle", true);
            anim.SetBool("Charge", false);

        }
    }

    Vector3 SetToBounce(Vector3 velocity)
    {
        return new Vector3(-velocity.x, velocity.y, 0);
    }
  
    public void Charging()
    {
        anim.SetBool("Jump", false);
        anim.SetBool("Idle", false);
        anim.SetBool("Charge", true);
    }

    public void GetPowerInfo(Vector3 force)
    {
        currentJumpForce = force;
        rb2d.AddForce(currentJumpForce);
        anim.SetBool("Jump", true);
        anim.SetBool("Idle", false);
        anim.SetBool("Charge", false);
    }
}
