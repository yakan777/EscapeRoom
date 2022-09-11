using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PushNAZO : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // if (!isPush) StartCoroutine(PushEye(eventData.pointerClick.name));
        if (!PushNAZOCheck.instance.isClear && !PushNAZOCheck.instance.isPush)
        {
            StartCoroutine(PushNAZOCheck.instance.PushEye(eventData.pointerClick));
        }
    }
}
