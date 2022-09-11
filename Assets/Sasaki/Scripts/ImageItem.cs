using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ImageItem : ItemSlot
{
    [SerializeField] Image imageObj;
    ItemImageButton itemImageButton;
    [SerializeField] ItemSlot combinePossibleItem;
    [SerializeField] ImageItem combinedItem;
    void Start()
    {
        itemImageButton = imageObj.GetComponent<ItemImageButton>();
    }

    //画面にイメージを拡大表示する
    public override void ClickEffect()
    {
        imageObj.gameObject.SetActive(true);
        imageObj.sprite = this.image;
        // itemImageButton.VisibleImage(this.image);
        if (combinedItem != null && combinePossibleItem != null)
        {
            Debug.Log("通った");
            itemImageButton.combineItem = combinePossibleItem;
            itemImageButton.combinedItem = combinedItem;
        }
    }
    public override void ClickEffect(GameObject item)
    {
        ClickEffect();
        if (itemImageButton != null) itemImageButton.item = item;
    }
}
