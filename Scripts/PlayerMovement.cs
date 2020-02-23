using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float MoveSpeed = 5f;

    public Rigidbody2D rb;

    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    //Upate gets the input for movement
    void Update()
    {
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);//converts mouse position on screen to world coordinates
        

    }

    //Used to move player based on the input
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
        //MovePosition moves the obj to the position that is input
        //fixe delta time makes it the spee of the movement oes not depend on how many times fixe update is called

        Vector2 lookDir = mousePos - rb.position;
        //gets direction o mouse position to where we are starring, to that we subtract 2 vectors
        //if we subtract 2 vector, we get a vector that points from one to the other, in that case we get a vector that points from the player to the mouse position
        //yet, we still need an ANGLE to rotate the Z axis so...

        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        //Atan2 is a math funtion that returns the angle between the X axis an the 2D vector starting at 0 and terminating at x,y
        //atan2 means Atan2(y,x), in this case is lookDir
        //attan2 returns in radians, so it nees to cnvert to degrees
        //if the player is following the ouse but only pointing to a 90 degree angle you can always add or subtract 90 degrees to suit your needs
        //finally we apply this to te palyer so...

        rb.rotation = angle;
    }
}
