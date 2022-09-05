using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    [SerializeField] GameObject appearItem;
    [SerializeField] GameObject[] wine;
    int wineCount = -1;
    public void OnClickObj()
    {
        Debug.Log("click");
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            wineCount++;
            wine[wineCount].SetActive(true);
            if (wineCount == 1)
            {
                appearItem.SetActive(true);
            }
        }
    }
}
