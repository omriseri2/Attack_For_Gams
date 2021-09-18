using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public AnimAndMoveControler moveControler;
    //isJumping
    public float jumpHeight = 3f;

    public Transform groundcheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
        if (isGrounded)
        {
            moveControler.isJump = false;
        }
        else
        {
            moveControler.isJump = true;
        }
    }
    public void j()
    {
        //velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        if (isGrounded)
        {
            rb.velocity += new Vector3(0, jumpHeight, 0);
            Debug.Log("jump");
        }
    }
}
