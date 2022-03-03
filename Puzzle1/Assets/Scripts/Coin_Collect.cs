using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player_Char")
        {
            Debug.Log("Coin Get!");
            Destroy(this.gameObject);
        }
    }
}
