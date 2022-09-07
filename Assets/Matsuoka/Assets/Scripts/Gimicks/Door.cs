using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Passward passward;
    void Update()
    {
        OpenDoor();
    }
    public void OpenDoor()
    {
        if (passward.IsClear())
        {
            Debug.Log("aita");
            transform.eulerAngles = new Vector3(0,120,0);
        }
    }
}
