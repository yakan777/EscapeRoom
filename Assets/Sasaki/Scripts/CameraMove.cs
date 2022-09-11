using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //シングルトン化
    public static CameraMove instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public bool isZoom;
    Vector3 preZoomPos;//ズーム前の位置
    Vector3 preZoomRot;//ズーム前の回転
    public GameObject movePanel;//左右移動のパネル
    public GameObject zoomOffButton;//カメラの戻るボタン
    Collider targetCol;//ズーム対象のコライダー
    public Transform cameraPos;//中央のカメラ位置
    void Start()
    {
        preZoomPos = transform.position;
        // preZoomRot = transform.rotation;
    }

    void Update()
    {
        //aキー押したらターゲットをズームする
        if (Input.GetKeyDown("a") && isZoom) ZoomOff();
    }
    public void Zoom(Transform target, Collider targetCol)
    {
        if (this.targetCol == null)
        {
            this.targetCol = targetCol;
            this.targetCol.enabled = false;
        }
        //移動パネルを表示非表示切り替え
        movePanel.SetActive(isZoom);
        zoomOffButton.SetActive(!isZoom);
        isZoom = !isZoom;

        transform.SetParent(target);
        transform.localScale = Vector3.one;
        transform.localPosition = Vector3.zero;
        transform.localEulerAngles = Vector3.zero;
    }
    public void ZoomOff()
    {
        if (this.targetCol != null)
        {
            this.targetCol.enabled = true;
            this.targetCol = null;
        }
        //移動パネルを表示非表示切り替え
        movePanel.SetActive(isZoom);
        zoomOffButton.SetActive(!isZoom);
        isZoom = !isZoom;

        transform.SetParent(cameraPos);
        transform.localScale = Vector3.one;
        transform.localPosition = preZoomPos;
        transform.localEulerAngles = Vector3.zero;
    }
}