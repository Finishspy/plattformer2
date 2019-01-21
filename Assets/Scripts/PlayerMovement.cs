using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed; //bestämer hastigheten 
    public float jumpHeight; //bestämer höjden man kan hoppa 

    private Rigidbody2D rbody;
    public GroundCheck groundCheck;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space)) //om man trycker space
        {
            if (groundCheck.touches > 0)  //Kollar att du nuddar marken 
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight); // du ändrar hastigheten i y så att du hoppar 
            }
        }
    }
}
