using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (ItemSlots.instance.selectItem != null)
            {
                ItemSlots.instance.selectItem.UseItem();
            }
        }
    }
}
