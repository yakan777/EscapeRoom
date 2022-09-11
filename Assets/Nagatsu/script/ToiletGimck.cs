using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletGimck : MonoBehaviour
{
    public NagatsuItem.Type clearItem;
    public bool isClearRed=false;
    public AudioClip sound2;
    AudioSource audioSource;

    public void Paper()
    {
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        if (isClear)
        {
            GetComponent<BoxCollider>().enabled = false;
            isClearRed=true;
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound2);

        }
    }

}
