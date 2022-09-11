using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateDoorSA : MonoBehaviour, IPointerClickHandler
{
    bool canOpen;//開けられるかどうか
    public bool isOpen;//開いてる状態か
    public bool isOpenIn;//内開きかなのか
    float rotY;//開き具合
    AudioSource audioSource;
    [SerializeField] AudioClip doorOpenSE;
    [SerializeField] AudioClip doorNotOpenSE;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //内開きなのか
        rotY = isOpenIn ? -120 : 120;

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        if (canOpen)
        {
            audioSource.PlayOneShot(doorOpenSE);
            //開いてるか
            float rot = !isOpen ? rotY : -rotY;
            transform.Rotate(0, rot, 0);
            isOpen = !isOpen;
        }
        else
        {
            audioSource.PlayOneShot(doorNotOpenSE);
            Debug.Log("開きません");
        }
    }
    public void OpenDoor()
    {
        canOpen = true;
    }
}
