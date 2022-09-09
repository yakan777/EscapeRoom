using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearKeys : MonoBehaviour
{
    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            PlayerPrefs.SetInt("Matsuoka", 0);
        }
        if (SceneManager.GetActiveScene().name == "SouthRoom")
        {
            PlayerPrefs.SetInt("Nagatsu", 0);
        }
        if (SceneManager.GetActiveScene().name == "NorthRoom")
        {
            PlayerPrefs.SetInt("Nagano", 0);
        }
        if (SceneManager.GetActiveScene().name == "WestRoom")
        {
            PlayerPrefs.SetInt("Sasaki", 0);
        }
        PlayerPrefs.Save();
    }

    public void UpdateKeys(string SceneName)
    {
        if (SceneName == "Main")
        {
            PlayerPrefs.SetInt("Matsuoka", 1);
            PlayerPrefs.Save();
        }
        if (SceneName == "Nagatsu")
        {
            PlayerPrefs.SetInt("Nagatsu", 1);
            PlayerPrefs.Save();
        }
        if (SceneName == "Nagano")
        {
            PlayerPrefs.SetInt("Nagano", 1);
            PlayerPrefs.Save();
        }
        if (SceneName == "Sasaki")
        {
            PlayerPrefs.SetInt("Sasaki", 1);
            PlayerPrefs.Save();
        }
    }
}
