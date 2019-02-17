using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCam1 : MonoBehaviour
{
    public GameObject Obj;
    public GameObject camOne;
    public GameObject camTwo;

    void OnTriggerEnter(Collider c)
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        if (c.CompareTag("Player")) //if player enters...
        {
            print("Player Detected in Room 1");
            cameraPositionCounter = 1; //change camera
        }
        cameraPositionChange(cameraPositionCounter);
    }

    public void cameraPositionChange(int camPosition)
    {
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if (camPosition == 1)
        {
            camOne.SetActive(false);

            camTwo.SetActive(true); //change cam
        }
    }
}