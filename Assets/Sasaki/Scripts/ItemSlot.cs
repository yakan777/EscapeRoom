using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    public new string name;//名前
    public Sprite image;//画像
    public ItemSlots itemList;//取得後に入るアイテムリスト
    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        itemList.PickUpItem(this);
    }
}
