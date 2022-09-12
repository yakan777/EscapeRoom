using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipScrollScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Z)){
            SceneManager.LoadScene("2DScroll");
        }

    }
}
