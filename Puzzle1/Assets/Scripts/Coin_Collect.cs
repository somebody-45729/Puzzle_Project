using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collect : MonoBehaviour
{
    bool flag = true;

    void OnTriggerEnter(Collider other)
    {
        if (flag == true)
        {
            if (other.tag == "Player")
            {
                Debug.Log("Coin Get!");
                Player_Move.addScore();
                flag = false;
                Destroy(this.gameObject);

            }
        }
    }
}
