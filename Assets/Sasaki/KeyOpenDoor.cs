using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KeyOpenDoor : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Board door;
    [SerializeField] AudioClip keySE;
    [SerializeField] AudioClip openSE;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (ItemSlots.instance.selectItem != null && ItemSlots.instance.selectItem.item.type == ItemSlot.TYPE.OPEN)
        {
            Debug.Log("ドアが開くようになった");
            if (!door.canOpen) audioSource.PlayOneShot(openSE);
            door.OpenDoor();
        }
        else
        {
            audioSource.PlayOneShot(keySE);
        }
    }
}
