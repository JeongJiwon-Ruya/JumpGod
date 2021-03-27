using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    bool scoreGet = false;

    
    public string GetThisTag()
    {
        return gameObject.tag;
        //Default -> GS 1
        //Red -> GS1.25
        //Blue -> GS0.75
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Charactor"))
        {
            if (scoreGet)
            {
                GameObject.Find("ScoreManager").GetComponent<ScoreManager>().ScorePP();
                scoreGet = true;
            }
            collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;

        }


    }


    public virtual void BlockAttribute()
    {

    }


}
