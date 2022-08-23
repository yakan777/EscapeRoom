using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;

    void Start()
    {
        item = ItemGenerater.instance.Spawn(itemType);
    }
    public void OnClickObj(){
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
