using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieGimick : MonoBehaviour
{
    public GameObject passwordnumber;
    public NagatsuItem.Type clearItem;
    public AudioClip sound4;
    AudioSource audioSource;
    private void Start() {
        passwordnumber.SetActive(false);
    }
    public void Numberon(){
        bool isClear = NagatsuItemBox.instance.TryUseBar(clearItem);
        if (isClear)
        {
            GetComponent<BoxCollider>().enabled = false;
            passwordnumber.SetActive(true);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound4);

        }

    }


}
