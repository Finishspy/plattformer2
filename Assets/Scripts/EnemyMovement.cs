using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool reverse = true;
    public bool vertical = false;
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) //en fusk kod som flippar fienden
        {
            Move(true);
        }
    }

    void Move(bool flip) // bestämer fiendens fart och flippar den om den nuddar en vägg  
    {
        if (flip == true) // flipa om sant 
        {
            reverse = !reverse; // is left får motsat värde 
        }

        if (vertical == true)
        {
            if (reverse == true) // om is left är sant 
            {
                rbody.velocity = new Vector2(rbody.velocity.x, -moveSpeed); // gör så att den går aup i y axeln och har samma värde i x axeln 
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);   // gör så att den går ner  i y axeln och har samma värde i x axeln
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        else
        {
            if (reverse == true) // om is left är sant 
            {
                rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y); // gör så den går högger 
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);   //gör så den går vänster 
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall") // om den nuddar en onsynlig vägg
        {
            Move(true);  // flippar fienden
        }
    }
}
