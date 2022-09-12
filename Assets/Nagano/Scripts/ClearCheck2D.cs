using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCheck2D : MonoBehaviour
{
    public float clearTime;
    // Start is called before the first frame update
    void Start()
    {
       // coinTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {

               clearTime += Time.deltaTime;

        if (clearTime >= 4.0f)
        {
            PlayerPrefs.SetInt("Nagano",1);
            SceneManager.LoadScene("CentralRoom");
        }
    }
}