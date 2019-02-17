using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code inspired by https://www.youtube.com/watch?v=CLSiRf_OrBk
public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter(Collider collide)
    {
        if(collide.CompareTag("Player"))
        {
            print("Power Up +1");
            Destroy(gameObject);
        }
    }
}
