using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    [SerializeField] int[] correctNumber;
    [SerializeField] SwitchButton[] switchButtons;
    [SerializeField] GameObject appearItem;
    //特定の色がそろったらアイテム出現

    private void Start()
    {
        appearItem.SetActive(false);
    }
    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("colorOK");
            appearItem.SetActive(true);
        }
    }

    bool IsClear()
    {
        for (int i = 0; i < switchButtons.Length; i++)
        {
            if (correctNumber[i] != switchButtons[i].buttonNumber)
            {
                return false;
            }
        }
        return true;
    }

}
