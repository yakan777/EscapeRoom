using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraClick : MonoBehaviour
{
    [SerializeField] MoveCamera moveCamera;
    [SerializeField] GameObject MoveToCamera;
    public void OnClickObj()
    {
        moveCamera.OnClickMoveCamera(MoveToCamera.transform.position,MoveToCamera.transform.rotation);
    }
}
