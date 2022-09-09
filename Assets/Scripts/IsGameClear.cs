using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsGameClear : MonoBehaviour
{
    public bool[] isClears;

    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("Matsuoka"));
        if (PlayerPrefs.GetInt("Matsuoka") == 1)
        {
            isClears[0] = true;
            Debug.Log("0ok");
        }
        if (PlayerPrefs.GetInt("Nagatsu") == 1)
        {
            isClears[1] = true;
            Debug.Log("1ok");
        }
        if (PlayerPrefs.GetInt("Sasaki") == 1)
        {
            isClears[2] = true;
            Debug.Log("2ok");
        }
        if (PlayerPrefs.GetInt("Nagano") == 1)
        {
            isClears[3] = true;
            Debug.Log("3ok");
        }
        if(IsEscape())
        {
            Debug.Log("Escape");
        }
    }
    bool IsEscape()
    {
        for (int i = 0; i < isClears.Length; i++)
        {
            if (isClears[i] == false)
            {
                return false;
            }
        }
        return true;
    }
}
