using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] Passward passward;
    [SerializeField] ClearKeys clearKeys;
    void Update()
    {
        OpenDoor();
    }
    public void OpenDoor()
    {
        if (passward.IsClear())
        {
            Debug.Log("aita");
            transform.eulerAngles = new Vector3(0,120,0);
            clearKeys.UpdateKeys(SceneManager.GetActiveScene().name);
            Debug.Log("Main"+PlayerPrefs.GetInt("Matsuoka"));
            SceneManager.LoadScene("CentralRoom");
        }
    }
}
