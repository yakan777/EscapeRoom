using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void OnClickStartButton() {
        FadeManager.Instance.LoadScene("2DScroll",0.0f);
    }
    void Update()
     {
            if (Input.GetKey(KeyCode.Return)){
            //オブジェクトを削除
        FadeManager.Instance.LoadScene("2DScroll",0.0f);
        }
     }
}