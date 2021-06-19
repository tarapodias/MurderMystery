using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player_movement : MonoBehaviour
{

    public Rigidbody2D playerRB;
    public float player_movement_speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); //get a reference to the Rigidbody2D component on this player game object
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow)) 
        {
            ///move player to the left
            playerRB.AddForce(Vector2.left * player_movement_speed);

        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            //move the player to the right
            playerRB.AddForce(Vector2.right * player_movement_speed);

        } 
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //move the player up
            playerRB.AddForce(Vector2.up * player_movement_speed);

        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            //move the player down
            playerRB.AddForce(Vector2.down * player_movement_speed);

        }

        
    }

    
}

