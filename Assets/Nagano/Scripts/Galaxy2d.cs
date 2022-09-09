using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Galaxy2d : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // coinTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0.1f, 0) );

    }
}