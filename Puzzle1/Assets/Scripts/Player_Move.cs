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

    public static int score = 0;
    void Update()
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
    
   
    void FixedUpdate()
    {

       
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Wall_byLength") // change this to tag version (easier)
        {
            playerRigidbody.velocity = Vector3.zero;
        }


      
        /*if (collision.gameObject.tag == "Coin")
        {
            score += 1;
            Debug.Log("Collecting Coin");
            Destroy(collision.gameObject);
            addScore();

        }*/
    }

    public static void addScore()
    {
      
        score++;
        Debug.Log("score");
        if (score == 5)
        {
            SceneManager.LoadScene(2);
        }
    }
}
