using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Destroy : MonoBehaviour
{

    int wall_hp = 3;

    void OnCollisionEnter2D(Collision2D collision)//needs collision argument
    {

        if (collision.gameObject.tag == "Bullet")
        {
            wall_hp = wall_hp - 1;

            if (wall_hp == 0)
            {
                Destroy(gameObject);  //clears game object after hit
            }

        }
    }

}
/*
  if (coll.gameObject.name == "bomb")
    {
        Destroy(coll.gameObject);
        this.GetComponent<healthScript>().health -= 1;
    }
*/