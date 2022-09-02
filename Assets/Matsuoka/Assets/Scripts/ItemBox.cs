using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots = default;
    [SerializeField] Slot selectedSlot = null;
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
    }
    public void SetItem(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
        //Debug.Log(item.type);
    }


    public void OnSelectSlot(int position)
    {
        foreach (Slot slot in slots)
        {
            slot.HideBgPanel();
        }
        selectedSlot=null;
        if (slots[position].Onselected())
        {
            selectedSlot = slots[position];
        }
    }

    public bool TryUseItem(Item.Type type)
    {
        if(selectedSlot == null)
        {
            return false;
        }
        if(selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBgPanel();
            selectedSlot=null;
            return true;
        }
        return false;
    }

    public bool SelectedSlot()
    {
        if(selectedSlot!=null)
        {
            return true;
        }
        return false;
    }

    public Item GetSelectedItem()
    {
        Item selectItem=selectedSlot.GetItem();
        return selectItem;
    }
}
