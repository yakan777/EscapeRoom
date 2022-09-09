using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FungusScene1 : MonoBehaviour
{
    public void nextFungusScene1(){
        FadeManager.Instance.LoadScene("2DFungusScroll",0f);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
