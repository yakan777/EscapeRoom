using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KinkoPassCheck : MonoBehaviour
{
    public RotateDoorSA door;
    [SerializeField] int[] correctNumbers;
    [SerializeField] PasswardButton[] passwardButtons;
    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("クリア");
            Debug.Log(passwardButtons[0].number);
            Debug.Log(passwardButtons[1].number);
            door.OpenDoor();
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
