using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float speed = 1;
    public float rotX = 0f;
    public float rotY = 0f;
    public float distance = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotX -= Input.GetAxis("Mouse Y") * speed;
        rotY += Input.GetAxis("Mouse X") * speed;
        rotX = Mathf.Clamp(rotX, 8f, 60f);
        rotY = Mathf.Repeat(rotY, 360f);

        Vector3 lookPosition = player.transform.position;
        Vector3 relativePos = Quaternion.Euler(rotX, rotY, 0) * new Vector3(0, 0, -distance);
        transform.position=lookPosition+relativePos;
        transform.LookAt(lookPosition);
    }
}
