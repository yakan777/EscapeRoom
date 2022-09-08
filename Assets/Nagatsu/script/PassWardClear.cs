using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassWardClear : MonoBehaviour
{
    public Passward passward;
    public GameObject door;


    // Update is called once per frame
    void Update()
    {
        if(passward.IsClear())
        {
            Debug.Log("kuria-!");
            Destroy(door);
        }        
    }
}
