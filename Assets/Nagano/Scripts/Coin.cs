using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public float coinTime;
    // Start is called before the first frame update
    void Start()
    {
       // coinTime = 0.0f;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);

               coinTime += Time.deltaTime;

        if (coinTime >= 4.0f)
        {
            SceneManager.LoadScene("2DFungusScroll");
        }
    }
}