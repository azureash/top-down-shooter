using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   //  public GameObject hitEffect;//for hit animation

   //only need collision function
   void OnCollisionEnter2D(Collision2D collision)//needs collision argument
    {
      //  GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);//quartenion.ientity means no rotation... also, thii s part of the collision effect, can be use later

      //  Destroy(effect, 5f); //clears collision effect after 5 seconds

        Destroy(gameObject);  //clears game object after hit 
    
    }
}
