using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedAngleFollow : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = .125f;
    public Vector3 offset; //how far the cam is from player

    // Start is called before the first frame update
    void Start()
    {
        if (!player)
        {
            player = GameObject.FindWithTag("Player").transform; //put gameobject with "Player" tag into this field
        }
    }

    // Update is called once per frame
    void Update()
    {
        print("Fixed Angle!");
        transform.position = player.position + offset;
    }
}
