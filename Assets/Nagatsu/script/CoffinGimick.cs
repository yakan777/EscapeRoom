using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoffinGimick : MonoBehaviour
{
    public GameObject lib;
    public NagatsuItem.Type clearItem;
    public AudioClip sound1;
    AudioSource audioSource;
    public void Futa()
    {
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        //audioSource = GetComponent<AudioSource>();
        if (isClear)
        {
            lib.SetActive(false);
            GetComponent<BoxCollider>().enabled = false;
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound1);
        }
    }


}
