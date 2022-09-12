using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
    [SerializeField]bool isDebugDelete;
    [SerializeField]bool isNagatsu;
    [SerializeField]bool isNagano;
    [SerializeField]bool isMatsuoka;
    [SerializeField]bool isSasaki;
    void Awake()
    {
        if(isDebugDelete){
            PlayerPrefs.DeleteKey("Nagano");
            PlayerPrefs.DeleteKey("Nagatsu");
            PlayerPrefs.DeleteKey("Sasaki");
            PlayerPrefs.DeleteKey("Matsuoka");
        }
        if(isNagano)PlayerPrefs.SetInt("Nagano",1);
        if(isNagatsu)PlayerPrefs.SetInt("Nagatsu",1);
        if(isSasaki)PlayerPrefs.SetInt("Sasaki",1);
        if(isMatsuoka)PlayerPrefs.SetInt("Matsuoka",1);
    }

}
