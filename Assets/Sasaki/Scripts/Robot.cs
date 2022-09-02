using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Robot : MonoBehaviour,IPointerClickHandler
{
    public Transform cameraPos;
    public void OnPointerClick(PointerEventData eventData){
        Camera.main.transform.position = cameraPos.position;
        Camera.main.transform.rotation = cameraPos.rotation;
    }
}
