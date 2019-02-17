using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//code copied from Assignment 2/3
//cleaned up a lot of extraneous code
public class Assignment5 : MonoBehaviour
{
    public Animator anim; //stores animations

    public GameObject Obj;
    public GameObject camOne;
    public GameObject camTwo;

    private float speed = 30;

    // Start is called before the first frame update
    void Start()
    {
        //Set default camera
        camOne.SetActive(true);
        //get the animator
        anim = GetComponent<Animator>();
        //anim.SetInteger("Movement", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //go forward
        {
            //print("W Pressed");
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            anim.SetInteger("Movement", 1); //change key for animation
        }
        else if (Input.GetKeyUp(KeyCode.W)) //stop animation
        {
            anim.SetInteger("Movement", 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //print("A Pressed");
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            anim.SetInteger("Movement", 1);
        }
        else if (Input.GetKeyUp(KeyCode.A)) //stop animation
        {
            anim.SetInteger("Movement", 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //print("S Pressed");
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            anim.SetInteger("Movement", 1);
        }
        else if (Input.GetKeyUp(KeyCode.S)) //stop animation
        {
            anim.SetInteger("Movement", 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //print("D Pressed");
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            anim.SetInteger("Movement", 1);
        }
        else if (Input.GetKeyUp(KeyCode.D)) //stop animation
        {
            anim.SetInteger("Movement", 0);
        }
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Powerup"))
        {
            print("Player touched Power up");
        }
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        if (c.CompareTag("Zone")) //if player enters...
        {
            print("Zone entered");
            cameraPositionCounter = 0; //change camera
        }
        if (c.CompareTag("Zone1")) //if player enters...
        {
            print("Zone1 entered");
            cameraPositionCounter = 1; //change cam
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
        }

        if (camPosition == 1)
        {
            camOne.SetActive(false);

            camTwo.SetActive(true); //change cam
        }
    }
}
