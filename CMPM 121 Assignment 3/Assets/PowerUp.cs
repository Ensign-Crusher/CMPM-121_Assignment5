using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code inspired by https://www.youtube.com/watch?v=CLSiRf_OrBk
//code also inspired by: https://www.youtube.com/watch?v=X-lW15kaZtM
public class PowerUp : MonoBehaviour
{
    public GameObject pickUpEffect;

    public Component doorCollider;

    void OnTriggerEnter(Collider c)
    {
        //Spawn effect
        Instantiate(pickUpEffect, transform.position, transform.rotation);

        //Open door
        doorCollider.GetComponent<OpenDoor>().hasKey = true; //Open door

        //Destroy gameobject
        print("You got the key");
        Destroy(gameObject);
    }
}
