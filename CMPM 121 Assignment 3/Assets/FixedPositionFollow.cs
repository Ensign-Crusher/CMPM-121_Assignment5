using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPositionFollow : MonoBehaviour
{
    public Transform player;

    public void Start()
    {
        if (!player)
        {
            player = GameObject.FindWithTag("Player").transform; //put gameobject with "Player" tag into this field
        }
    }

    void Update()  //keep looking at player; fixed position
    {
        print("Fixed Position!");
        transform.LookAt(new Vector3(player.position.x, player.position.y, player.position.z));
    }

    /*void OnDrawGizmosSelected() //Testing out if camera shots work
    {
        if (!Application.isPlaying)
        {
            CutToShot();
        }
    }*/
}
