using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    [SerializeField] GameObject appearItem;
    [SerializeField] GameObject appearItem2;
    [SerializeField] GameObject[] wine;
    int wineCount = -1;
    private void Start() {
        appearItem.SetActive(false);
        appearItem2.SetActive(false);
    }
    public void OnClickObj()
    {
        Debug.Log("click");
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            appearItem.SetActive(true);
            appearItem2.SetActive(true);
        }
    }
}
