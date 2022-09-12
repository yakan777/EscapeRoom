using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickGimick : MonoBehaviour
{
    [SerializeField] StickButton[] stickButtons;
    [SerializeField] int[] correctNumbers;
    [SerializeField] GameObject appearItem;

    private void Start()
    {
        appearItem.SetActive(false);
    }
    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("OK");
            appearItem.SetActive(true);
        }
    }
    bool IsClear()
    {
        for (int i = 0; i < correctNumbers.Length; i++)
        {
            if (stickButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }
        return true;
    }
}
