using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Camera switch code inspired by: https://www.youtube.com/watch?v=vZXGbTdk8gA
public class Assignment2 : MonoBehaviour
{

    public GameObject Obj;
    public GameObject camOne;
    public GameObject camTwo;
    public GameObject camThree;

    AudioListener camOneAudioLis;
    AudioListener camTwoAudioLis;

    private float speed = 5;

    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        camOneAudioLis = camOne.GetComponent<AudioListener>();
        camTwoAudioLis = camTwo.GetComponent<AudioListener>();
    }

    // Update is called once per frame
    void Update()
    {
        switchCamera();
        if (Input.GetKey(KeyCode.W))
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
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
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
        cameraPositionChange(cameraPositionCounter);
    }

    public void cameraPositionM()
    {
        cameraChangeCounter();
    }

    void switchCamera()
    {
    }

    void cameraChangeCounter()
    {
        
    }

    void cameraPositionChange(int camPosition)
    {
        if(camPosition > 1)
        {
            //camPosition = 0;
        }
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if(camPosition == 0)
        {
            camOne.SetActive(true);
            camOneAudioLis.enabled = true;

            camTwo.SetActive(false);
            camTwoAudioLis.enabled = false;

            camThree.SetActive(false);
        }

        if (camPosition == 1)
        {
            camOne.SetActive(false);
            camOneAudioLis.enabled = false;

            camTwo.SetActive(true);
            camTwoAudioLis.enabled = true;

            camThree.SetActive(false);
        }

        if (camPosition == 2)
        {
            camOne.SetActive(false);
            camOneAudioLis.enabled = false;

            camTwo.SetActive(false);
            camTwoAudioLis.enabled = false;

            camThree.SetActive(true);
            camTwoAudioLis.enabled = true;
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
    void OnTriggerEnter(Collider collide)
    {
        if (collide.CompareTag("Powerup"))
        {
            print("Player touched Power up");
            points++;
        }
    }
}
