using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCameraOnClickPanel : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;
    [SerializeField] GameObject[] mainRoomCameras;
    [SerializeField] GameObject[] room1Cameras;
    [SerializeField] GameObject[] room2Cameras;
    [SerializeField] GameObject[] room3Cameras;
    [SerializeField] GameObject backPanel;
    [SerializeField] GameObject rightPanel;
    [SerializeField] GameObject leftPanel;
    Vector3 defaultPosition;
    Quaternion defaultRotation;

    Vector3 startPosition;
    Quaternion startRotation;
    Vector3 stackPosition;
    Quaternion stackRotation;

    int cameraNumber;

    public static MoveCameraOnClickPanel instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        backPanel.SetActive(false);
        defaultPosition = cameras[0].transform.position;
        defaultRotation = cameras[0].transform.rotation;
        startPosition = defaultPosition;
        startRotation = defaultRotation;
        foreach (GameObject camera in room1Cameras)
        {
            camera.SetActive(false);
        }
        foreach (GameObject camera in room2Cameras)
        {
            camera.SetActive(false);
        }
        foreach (GameObject camera in room3Cameras)
        {
            camera.SetActive(false);
        }
        foreach (GameObject camera in cameras)
        {
            camera.SetActive(false);
        }
        cameras[0].SetActive(true);
    }

    public void SetZoomCamera(GameObject camera)
    {
        stackPosition = cameras[0].transform.position;
        stackRotation = cameras[0].transform.rotation;
        //zoom
        cameras[0].transform.position = camera.transform.position;
        cameras[0].transform.rotation = camera.transform.rotation;

        backPanel.SetActive(true);
        rightPanel.SetActive(false);
        leftPanel.SetActive(false);
    }

    public void OnclickBackPanel()
    {
        //modoru
        cameras[0].transform.position = stackPosition;
        cameras[0].transform.rotation = stackRotation;
        backPanel.SetActive(false);
        rightPanel.SetActive(true);
        leftPanel.SetActive(true);

    }



    public void OnclickMainRoomDoor()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].transform.position = mainRoomCameras[i].transform.position;
            cameras[i].transform.rotation = mainRoomCameras[i].transform.rotation;
        }
        defaultPosition = startPosition;
        defaultRotation = startRotation;
    }

    public void OnclickRoom1Door()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].transform.position = room1Cameras[i].transform.position;
            cameras[i].transform.rotation = room1Cameras[i].transform.rotation;
        }
        defaultPosition = room1Cameras[0].transform.position;
        defaultRotation = room1Cameras[0].transform.rotation;
    }
    public void OnclickRoom2Door()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].transform.position = room2Cameras[i].transform.position;
            cameras[i].transform.rotation = room2Cameras[i].transform.rotation;
        }
        defaultPosition = room2Cameras[0].transform.position;
        defaultRotation = room2Cameras[0].transform.rotation;
    }
    public void OnclickRoom3Door()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].transform.position = room3Cameras[i].transform.position;
            cameras[i].transform.rotation = room3Cameras[i].transform.rotation;
        }
        defaultPosition = room3Cameras[0].transform.position;
        defaultRotation = room3Cameras[0].transform.rotation;
    }

    public void OnClickMoveCamera(Vector3 cameraPosition, Quaternion cameraRotation)
    {
        cameras[0].transform.position = cameraPosition;
        cameras[0].transform.rotation = cameraRotation;
        for (int i = 1; i < cameras.Length; i++)
        {
            if (cameras[0].transform.position == cameras[i].transform.position)
            {
                cameraNumber = i;
            }
        }
    }

    public void OnClickRightCameraButton()
    {
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

    public void OnClickLeftCameraButton()
    {
        cameraNumber--;
        if (cameraNumber < 0)
        {
            cameraNumber = cameras.Length - 1;
            cameras[0].transform.position = cameras[cameraNumber].transform.position;
            cameras[0].transform.rotation = cameras[cameraNumber].transform.rotation;
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
