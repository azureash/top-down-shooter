using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f; 

    // Update is called once per frame
    void Update()
    {
        //if player hits mouse 1, it executes func shooting
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
         
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//creates the bullet
        //instantiates the bullet prefab on the pos and rot efined by firepoint 
        //now it can be use as variable

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();//attributes the bullet to a rigidboy
        //now store bullet in another variable, so you can use the function...

        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);//makes bullet fly in a certain direction
        

    }
}
