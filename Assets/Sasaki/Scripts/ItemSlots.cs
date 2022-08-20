using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlots : MonoBehaviour
{
    public GameObject imagePrefabs;
    public List<ItemSlot> list = new List<ItemSlot>();
    public void PickUpItem(ItemSlot item)
    {
        Debug.Log(item.name);
        list.Add(item);
        GameObject image = Instantiate(imagePrefabs);
        // image.transform.parent = this.transform;
        image.transform.SetParent(this.transform, false);
        image.GetComponent<Image>().sprite = item.image;
    }
}
