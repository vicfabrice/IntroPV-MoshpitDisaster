using UnityEngine;
using System.Collections;

public class PlayerMobility : MonoBehaviour
{

    public static float speed = 1.0f;
    public static Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public static Animator animator;


    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        
        //Attach animations triggers to Player
        Anim();
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }

    void Anim()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("PlayerWalkAdelante");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                animator.SetTrigger("PlayerWalkAtras");
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    animator.SetTrigger("PlayerWalkIzq");
                }
                else
                {
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {

                        animator.SetTrigger("PlayerWalkDer");
                    }
                }
            }
        }
    }

    public static void Escabio()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        rb2d.AddForce(movement * speed);

    } 

}