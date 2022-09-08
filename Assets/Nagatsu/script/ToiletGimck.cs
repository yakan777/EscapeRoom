using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletGimck : MonoBehaviour
{
    public NagatsuItem.Type clearItem;
    public bool isClearRed=false;
    public void Paper()
    {
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        if (isClear)
        {
            GetComponent<BoxCollider>().enabled = false;
            isClearRed=true;

        }
    }

}
