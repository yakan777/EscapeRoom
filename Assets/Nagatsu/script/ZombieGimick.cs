using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGimick : MonoBehaviour
{
    public GameObject passwordnumber;
    public NagatsuItem.Type clearItem;
    private void Start() {
        passwordnumber.SetActive(false);
    }
    public void Numberon(){
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        if (isClear)
        {
            GetComponent<BoxCollider>().enabled = false;
            passwordnumber.SetActive(true);

        }

    }


}
