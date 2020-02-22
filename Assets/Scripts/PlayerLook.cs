using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
  
    public float jumpTime = 10.0f;
    private float nextJump; 
    Vector3 veloctiy;
    bool isGrounded;
    public float jumpPower;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && veloctiy.y < 0) 
        {
            veloctiy.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        //if the player is jumping
        if(Input.GetKey(KeyCode.Space) ) 
        {

            // jumpPower = Mathf.Sqrt(jumpHeight * 2 * gravity)/10;
          
            jumpPower += 0.07f;
            if (jumpPower >= 3) { jumpPower = 3; }

            veloctiy.y += jumpPower;
            Debug.Log("Jump");
        }else if (!Input.GetKey(KeyCode.Space)) 
        {
           
            jumpPower -= 0.1f;
            if (jumpPower <= 0) { jumpPower = 0; }
            Debug.Log("not jump");
        }

        veloctiy.y -= gravity * Time.deltaTime;

        controller.Move(veloctiy * Time.deltaTime);
    }
}
