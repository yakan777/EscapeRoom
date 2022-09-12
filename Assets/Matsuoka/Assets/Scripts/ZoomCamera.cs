using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomCamera : MonoBehaviour
{
    [SerializeField] GameObject zoomCamera;
    [SerializeField] GameObject rightPanel;
    [SerializeField] GameObject leftPanel;

    public void OnClickCamera()
    {
        MoveCameraOnClickPanel.instance.SetZoomCamera(zoomCamera);
    }

    public void OnclickBackPanel()
    {
        MoveCameraOnClickPanel.instance.OnclickBackPanel();
    }
}
