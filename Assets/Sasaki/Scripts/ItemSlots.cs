using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlots : MonoBehaviour
{
    public GameObject imagePrefabs;
    // public List<ItemSlot> list = new List<ItemSlot>();
    public List<GameObject> list = new List<GameObject>();
    public SlotItem selectItem;

    public static ItemSlots instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PickUpItem(ItemSlot item)
    {
        Debug.Log(item.name);
        //Imageオブジェクトを生成し、SlotItemコンポーネントと画像を設定
        GameObject image = Instantiate(imagePrefabs);
        // list.Add(image.GetComponent<ItemSlot>());
        list.Add(image);
        image.transform.SetParent(this.transform, false);
        SlotItem slotItem = image.AddComponent<SlotItem>();
        // image.GetComponent<SlotItem>().name = item.name;
        slotItem.name = item.name;
        slotItem.item = item;
        image.GetComponent<Image>().sprite = item.image;

        //画像のアルファ値調整
        Image alpha = image.GetComponent<Image>();
        // nantoka.color = new Color(1, 1, 1, 0.4f);
        alpha.color = new Color32(255, 255, 255, 100);
    }
    public void RemoveItem(string item)
    {
        foreach (GameObject i in list)
        {
            Debug.Log("List:" + i.GetComponent<SlotItem>().name + "item:" + item);
            if (i.GetComponent<SlotItem>().name == item)
            {
                list.Remove(i);
                return;
            }
        }
    }
}
