using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickGimick : MonoBehaviour
{
    [SerializeField] StickButton[] stickButtons;
    [SerializeField] int[] correctNumbers;
    public void CheckClear()
    {
        if(IsClear())
        {
            Debug.Log("OK");
        }
    }
    bool IsClear()
    {
        for(int i=0;i<correctNumbers.Length;i++)
        {
            if(stickButtons[i].number!=correctNumbers[i])
            {
                return false;
            }
        }
        return true;
    }
}
