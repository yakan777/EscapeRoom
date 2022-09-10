using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    public enum TYPE
    {
        KEY,
        HINT
    }
    public TYPE type;
    public new string name;//名前
    public Sprite image;//画像
    public ItemSlots itemList;//取得後に入るアイテムリスト
    public void OnPointerClick(PointerEventData eventData)
    {
        // ClickEffect();
        gameObject.SetActive(false);
        ItemSlots.instance.PickUpItem(this);
    }
    public virtual void ClickEffect()
    {
        Debug.Log("※オーバーライドしてません");
    }
    //作成中
    // public bool UseItem()
    // {
    //     switch (type)
    //     {
    //         case TYPE.KEY:
    //             return true;
    //         case TYPE.HINT:
    //             Debug.Log("ヒントだよ");
    //             break;
    //     }
    //     return false;
    // }
}
