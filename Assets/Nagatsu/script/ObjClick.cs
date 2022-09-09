using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjClick : MonoBehaviour
{
    public GameObject obj;
    NagatsuItemList nagatsuItemList;
    public void OnClickObj()
    {
        nagatsuItemList.OnClickObj();
        gameObject.SetActive(false);   
    }
}
