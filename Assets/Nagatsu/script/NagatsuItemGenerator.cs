using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagatsuItemGenerator : MonoBehaviour
{
   [SerializeField] UseItemListEntity itemListEntity;

    public static NagatsuItemGenerator instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public NagatsuItem Spawn(NagatsuItem.Type type)
    {
        foreach (NagatsuItem item in itemListEntity.itemList)
        {
            Debug.Log(item.type);
            Debug.Log("toutatu");
            if (item.type == type)
            {
                return new NagatsuItem(item.type, item.sprite, item.zoomObj,item.hp);
            }
        }
        return null;
    }
    public GameObject GetZoomItem(NagatsuItem.Type type)
    {
        foreach(NagatsuItem item in itemListEntity.itemList)
        {
            if(item.type == type)
            {
                return item.zoomObj;
            }
        }
        return null;
    }
}
