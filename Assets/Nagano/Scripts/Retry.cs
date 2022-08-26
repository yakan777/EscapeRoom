using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void OnClickStartButton() {
       SceneManager.LoadScene("2DScroll");
    }
}