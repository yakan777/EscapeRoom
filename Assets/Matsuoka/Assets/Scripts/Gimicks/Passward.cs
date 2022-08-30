using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passward : MonoBehaviour
{
    [SerializeField] int[] correctNumbers;
    public void CheckClear()
    {
        if(IsClear())
        {
            Debug.Log("クリア");

        }
    }

    bool IsClear()
    {
        return true;
    }
}
