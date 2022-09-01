using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FungusScene2DScroll : MonoBehaviour
{
    public void nextScrollScene(){
        FadeManager.Instance.LoadScene("2DScroll",0.3f);

    }    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
