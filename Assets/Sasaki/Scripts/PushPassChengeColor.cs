using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PushPassChengeColor : MonoBehaviour,IPointerClickHandler
{
    Color white = Color.white;
    Color black = Color.black;
    public Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData){
        if(!PushPassCheck.instance.isClear){
            material.color = material.color==white?black:white;
            PushPassCheck.instance.passCheck();
        }
    }
}
