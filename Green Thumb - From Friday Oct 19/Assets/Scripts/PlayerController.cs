using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Rigidbody rigid;

    public int movementSpeed;

    private Vector3 prev;
    private Vector3 curr;

    void Update()
    {


        
    }

    private void FixedUpdate()
    {
        prev = gameObject.transform.position;
        //you use arrow keys/wasd and you face the way you're walking 

        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
        curr = gameObject.transform.position;

        //rigid.velocity = (curr - prev) / Time.deltaTime;
    }
}
