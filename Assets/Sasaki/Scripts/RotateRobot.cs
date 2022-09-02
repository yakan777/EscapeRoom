using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRobot : MonoBehaviour
{
    public float rotSpeed;
    public bool isClear;
    void Start()
    {

    }

    void Update()
    {
        if(!isClear || Mathf.Abs(transform.eulerAngles.y) > 0.1f){
            transform.Rotate(0,rotSpeed,0);
        }
    }
    public void ClearCheck(){
        isClear = true;
    }
}
