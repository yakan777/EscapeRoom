using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraClick : MonoBehaviour
{
    [SerializeField] MoveCamera moveCamera;
    [SerializeField] GameObject camera;
    public void OnClickObj()
    {
        moveCamera.OnClickMoveCamera(camera.transform.position,camera.transform.rotation);
    }
}
