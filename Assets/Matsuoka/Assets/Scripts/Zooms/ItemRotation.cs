using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    [SerializeField] Transform parent;

    //ドラッグで回転
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float x = Input.GetAxis("Mouse X") * Time.deltaTime * 100;
            float y = Input.GetAxis("Mouse Y") * Time.deltaTime * 100;
            //transform.Rotate(y, -x, 0);
            transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles) * Vector3.up, -x);
            transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles) * Vector3.right, y);
        }
    }
}
