using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotate = 90;
    public void RightRotate()
    {
        transform.Rotate(0, rotate, 0);
        Debug.Log("Rightボタン");
    }
    public void LeftRotate()
    {
        transform.Rotate(0, -rotate, 0);
        Debug.Log("Leftボタン");
    }
}
