using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code copied from Assignment 2
public class Assignment3 : MonoBehaviour
{

    public GameObject Obj;
    public GameObject camOne;
    public GameObject camTwo;
    public GameObject camThree;
    public GameObject camFour;

    private float speed = 30;


    // Start is called before the first frame update
    void Start()
    {
        camOne.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera();
        if (Input.GetKey(KeyCode.W)) //go forward
        {
            print("W Pressed");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("A Pressed");
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            print("S Pressed");
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("D Pressed");
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        //Below is debugging for camera switching
        /*int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C Pressed");
            cameraPositionCounter = 0;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            print("V Pressed");
            cameraPositionCounter = 1;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            print("B Pressed");
            cameraPositionCounter = 2;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            print("N Pressed");
            cameraPositionCounter = 3;
        }
        cameraPositionChange(cameraPositionCounter);*/
    }

    public void cameraPositionM()
    {
        cameraChangeCounter();
    }

    public void switchCamera()
    {
        
    }

    public void cameraChangeCounter()
    {
        
        //cameraPositionCounter++;
        
    }

    void OnTriggerEnter(Collider c)
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        if (c.CompareTag("Zone")) //if player enters...
        {
            print("Zone entered");
            cameraPositionCounter = 0; //change camera
        }
        if (c.CompareTag("Zone1")) //if player enters...
        {
            print("Zone1 entered");
            cameraPositionCounter = 1;
        }
        if (c.CompareTag("Zone2")) //if player enters...
        {
            print("Zone2 entered");
            cameraPositionCounter = 2;
        }
        if (c.CompareTag("Zone3")) //if player enters...
        {
            print("Zone3 entered");
            cameraPositionCounter = 3;
        }
        cameraPositionChange(cameraPositionCounter);
    }

    public void cameraPositionChange(int camPosition)
    {
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if (camPosition == 0)
        {
            camOne.SetActive(true); //change cam

            camTwo.SetActive(false);

            camThree.SetActive(false);

            camFour.SetActive(false);
        }

        if (camPosition == 1)
        {
            camOne.SetActive(false);

            camTwo.SetActive(true); //change cam

            camThree.SetActive(false);

            camFour.SetActive(false);
        }

        if (camPosition == 2)
        {
            camOne.SetActive(false);

            camTwo.SetActive(false);

            camThree.SetActive(true); //change cam

            camFour.SetActive(false);
        }

        if (camPosition == 3)
        {
            camOne.SetActive(false);

            camTwo.SetActive(false);

            camThree.SetActive(false);

            camFour.SetActive(true); //change cam
        }
    }
}
