using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject subCamera;

    // Start is called before the first frame update
    void Start()
    {
        subCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            mainCamera.SetActive(false);
            subCamera.SetActive(true);
        }

    }
}
