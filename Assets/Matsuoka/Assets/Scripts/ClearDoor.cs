using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearDoor : MonoBehaviour
{
    [SerializeField] int clearNumber;
    [SerializeField] GameObject door1;
    [SerializeField] GameObject door2;
    public void OnClickDoor()
    {
        if (clearNumber == 3)
        {
            door1.SetActive(false);
            door2.SetActive(false);
            GetComponent<BoxCollider>().enabled = false;
        }
    }
    public void Count()
    {
        clearNumber++;
    }
}
