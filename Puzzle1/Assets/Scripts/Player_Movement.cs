using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 2.5f;
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w")) // w key for up
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s")) // s key for down
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d")) // d key for right
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a")) // a key for left
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
}
