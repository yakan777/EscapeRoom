using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemImageButton : MonoBehaviour, IPointerClickHandler
{
    Image image;
    public GameObject item;
    public ItemSlot combineItem;
    public ImageItem combinedItem;
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void VisibleImage(Sprite sprite)
    {
        gameObject.SetActive(true);
        image.sprite = sprite;
    }
    public void UnVisibleImage()
    {
        gameObject.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (ItemSlots.instance.selectItem.name == combineItem.name)
        {
            Debug.Log("合成しました");
            ItemSlots.instance.RemoveItem(ItemSlots.instance.selectItem.name);
            Destroy(ItemSlots.instance.selectItem.gameObject);
            ItemSlots.instance.RemoveItem(item.GetComponent<SlotItem>().name);
            Destroy(item);
            if (combinedItem != null) ItemSlots.instance.PickUpItem(combinedItem);
            item = null;
            image.sprite = null;
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("合成できません！！");
        }
    }
}
