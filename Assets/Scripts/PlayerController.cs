using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
   private float Speed = 20.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 10.0f;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       

        moveVector = Vector3.zero;
        if(controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity;
        }
        moveVector.x = -Speed;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxisRaw("Horizontal") * Speed;

        controller.Move(moveVector * Time.deltaTime);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "engel")
        {  
            FindObjectOfType<AudioManager>().PlaySound("gameover");
           
            Manager.gameOver = true;
          
        }
    }
   
}