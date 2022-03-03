using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
