using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class KinkoPassCheck : MonoBehaviour
{
    public RotateDoorSA door;
    [SerializeField] int[] correctNumbers;
    [SerializeField] PasswardButton[] passwardButtons;
    AudioSource audioSource;
    [SerializeField] AudioClip pushSE;
    [SerializeField] AudioClip correctSE;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void CheckClear()
    {
        if (IsClear())
        {
            audioSource.PlayOneShot(correctSE);
            Debug.Log("クリア");
            Debug.Log(passwardButtons[0].number);
            Debug.Log(passwardButtons[1].number);
            door.OpenDoor();
        }
    }

    public bool IsClear()
    {
        audioSource.PlayOneShot(pushSE);
        for (int i = 0; i < passwardButtons.Length; i++)
        {
            if (passwardButtons[i].number != correctNumbers[i])
            {
                return false;
            }
        }
        return true;
    }
}
