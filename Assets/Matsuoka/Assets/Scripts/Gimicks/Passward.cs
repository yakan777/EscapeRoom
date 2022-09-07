using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passward : MonoBehaviour
{
    [SerializeField] int[] correctNumbers;
    [SerializeField] PasswardButton[] passwardButtons;
    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("クリア");
            Debug.Log(passwardButtons[0].number);
            Debug.Log(passwardButtons[1].number);
        }
    }

    public bool IsClear()
    {
        for(int i = 0; i<passwardButtons.Length;i++)
        {
            if(passwardButtons[i].number!=correctNumbers[i])
            {
                return false;
            }
        }
        return true;
    }
}
