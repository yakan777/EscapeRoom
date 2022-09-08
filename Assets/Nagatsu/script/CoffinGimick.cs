using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinGimick : MonoBehaviour
{
    public GameObject lib;
    public NagatsuItem.Type clearItem;
    public void Futa()
    {
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        if (isClear)
        {
            lib.SetActive(false);
            GetComponent<BoxCollider>().enabled = false;

        }
    }


}
