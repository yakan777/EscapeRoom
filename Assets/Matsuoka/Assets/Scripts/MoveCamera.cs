using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject subCamera;
    [SerializeField] GameObject[] cameras;
    Vector3 defaultPosition;
    Quaternion defaultRotation;
    int cameraNumber;

    void Start()
    {
        defaultPosition = cameras[0].transform.position;
        defaultRotation = cameras[0].transform.rotation;
        foreach (GameObject camera in cameras)
        {
            camera.SetActive(false);
        }
        cameras[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //cameras[cameraNumber].SetActive(false);
            cameraNumber++;
            if (cameraNumber >= cameras.Length)
            {
                cameraNumber = 0;
            }
            if (cameraNumber != 0)
            {
                cameras[0].transform.position = cameras[cameraNumber].transform.position;
                cameras[0].transform.rotation = cameras[cameraNumber].transform.rotation;
            }
            else
            {
                cameras[0].transform.position = defaultPosition;
                cameras[0].transform.rotation = defaultRotation;
            }
        }

    }
}
