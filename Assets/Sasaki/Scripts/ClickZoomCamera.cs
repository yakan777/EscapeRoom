using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickZoomCamera : MonoBehaviour, IPointerClickHandler
{
    CameraMove gameCamera;
    Collider col;
    void Start()
    {
        gameCamera = CameraMove.instance;
        col = GetComponent<BoxCollider>();
    }

    void Update()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("ズームした");
        if (!gameCamera.isZoom) gameCamera.Zoom(this.transform, col);
    }
}
