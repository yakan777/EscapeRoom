using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotItem : MonoBehaviour, IPointerClickHandler
{
    public bool isSelect;
    Image image;
    new public string name;
    public ItemSlot item;
    void Start()
    {
        image = GetComponent<Image>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isSelect)
        {
            //アイテムリスト内を一度全て未選択状態にする
            foreach (GameObject gm in ItemSlots.instance.list)
            {
                SlotItem slot = gm.GetComponent<SlotItem>();
                slot.isSelect = false;
                slot.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.4f);
            }

            //クリックしたアイテムを選択状態にする
            isSelect = !isSelect;
            image.color = new Color(1f, 1f, 1f, 1f);
            ItemSlots.instance.selectItem = this;
            Debug.Log("アイテム選択");
        }
        else
        {
            if (item.type == ItemSlot.TYPE.HINT) item.ClickEffect(eventData.pointerClick.gameObject);
            if (item.type == ItemSlot.TYPE.KEY) item.ClickEffect();
        }
    }
    public void UseItem()
    {
        Debug.Log($"{ItemSlots.instance.selectItem.name}を使った");
    }
}
