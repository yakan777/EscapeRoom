using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimick : MonoBehaviour
{
    [SerializeField] Item.Type clearItem;
    public void OnClickObj()
    {
        Debug.Log("click");
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            gameObject.SetActive(false);
        }
    }
}
