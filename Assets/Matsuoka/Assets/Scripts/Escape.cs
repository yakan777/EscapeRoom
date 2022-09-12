using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{
    [SerializeField] ClearKeys clearKeys;
    public void OnclickEscape()
    {
        clearKeys.UpdateKeys(SceneManager.GetActiveScene().name);
        Debug.Log("Main" + PlayerPrefs.GetInt("Matsuoka"));
        SceneManager.LoadScene("CentralRoom");
    }
}
