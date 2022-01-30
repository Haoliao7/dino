using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Vector2 jumpForce;
    public int jumpLimit;


    public  Quaternion crouch;
    public Quaternion stand;

    public GameObject lose;


    // Start is called before the first frame update
    void Start()
    {
        jumpLimit = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && jumpLimit<2)//if prss space (player can only double jump, they can't do triple)
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce); // add force to jump!

            jumpLimit++;
        }


        if (Input.GetKeyDown(KeyCode.DownArrow)) // if pressing down arrow
        {
       
            transform.position= new Vector2 (transform.position.x, -2.957f); // make it lower so the movement will look smoother
            gameObject.transform.rotation = crouch; // rotation it to crouch down
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))// if realeasing down arrow
        {
            transform.position = new Vector2(transform.position.x, -2.471f);// make it higher so the movement will look smoother
            gameObject.transform.rotation = stand;// rotation it to stand up
        }


        //lose condition

        if (transform.position.x < -10) { //if the player be pushed out of the screen

            lose.SetActive(true); //they lose, unfortunately

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground") { // if the player touch the ground
            jumpLimit = 0; // they can jump again
        }

    }


}
