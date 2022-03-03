using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Move : MonoBehaviour
{
    public Rigidbody playerRigidbody;

    public int playerSpeed = 10;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerRigidbody.velocity = new Vector3(-playerSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerRigidbody.velocity = new Vector3(playerSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRigidbody.velocity = new Vector3(0, 0, playerSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerRigidbody.velocity = new Vector3(0, 0, -playerSpeed);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall_byLength")
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }

    
}
