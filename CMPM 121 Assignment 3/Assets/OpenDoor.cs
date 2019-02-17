using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animation hinge;

    public bool hasKey = false;

    void Update()
    {
        if (hasKey == true)
        {
            print("Open Sesame");
            hinge.Play();
        }
        hasKey = false;
    }
}
