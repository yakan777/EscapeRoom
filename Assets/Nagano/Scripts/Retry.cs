using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void OnClickStartButton() {
       SceneManager.LoadScene("2DScroll");
    }
    void Update()
     {
            if (Input.GetKey(KeyCode.Return)){
            //オブジェクトを削除
           SceneManager.LoadScene("2DScroll");
        }
     }
}