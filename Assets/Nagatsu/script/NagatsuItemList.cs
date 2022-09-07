using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagatsuItemList : MonoBehaviour
{
    [SerializeField] NagatsuItem.Type itemtype;
    NagatsuItem nagatsuItem;
    void Start()
    {
        Debug.Log("kite");
        nagatsuItem = NagatsuItemGenerator.instance.Spawn(itemtype);
        Debug.Log("toutatunagatu");
    }
    public void OnClickObj()
    {
        NagatsuItemBox.instance.SetItem(nagatsuItem);
    }


}
