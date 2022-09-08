using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagatsuItemBox : MonoBehaviour
{
    [SerializeField] NagatsuSlot[] slots = default;
    [SerializeField] NagatsuSlot selectedSlot = null;
    public static NagatsuItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<NagatsuSlot>();
        }
    }
    public void SetItem(NagatsuItem item)
    {
        foreach (NagatsuSlot slot in slots)
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
        foreach (NagatsuSlot slot in slots)
        {
            slot.HideBgPanel();
        }
        selectedSlot = null;
        if (slots[position].Onselected())
        {
            selectedSlot = slots[position];
        }
    }

    public bool TryUseItem(NagatsuItem.Type type)
    {
        if (selectedSlot == null)
        {
            return false;
        }
        if (selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBgPanel();
            selectedSlot = null;
            return true;
        }
        return false;
    }
    public bool TryUseBar(NagatsuItem.Type type)
    {
        if (selectedSlot == null)
        {
            return false;
        }
        if (selectedSlot.GetItem().type == type)
        {
            selectedSlot.GetItem().hp--;
            if (selectedSlot.GetItem().hp <= 0)
            {
                selectedSlot.SetItem(null);
                selectedSlot.HideBgPanel();
                selectedSlot = null;

            }
            return true;
        }
        return false;
    }

    public bool SelectedSlot()
    {
        if (selectedSlot != null)
        {
            return true;
        }
        return false;
    }

    public NagatsuItem GetSelectedItem()
    {
        NagatsuItem selectItem = selectedSlot.GetItem();
        return selectItem;
    }

}
