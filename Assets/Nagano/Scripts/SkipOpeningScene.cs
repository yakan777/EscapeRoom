using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipScene2D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Z)){
            SceneManager.LoadScene("2DClear");

    }
}
}
