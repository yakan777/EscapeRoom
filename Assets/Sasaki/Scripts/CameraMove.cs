using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public bool isZoom;
    Vector3 preZoomPos;//ズーム前の位置
    Vector3 preZoomRot;//ズーム前の回転
    public GameObject movePanel;//左右移動のパネル
    public Transform target;
    void Start()
    {
        // preZoomPos = transform.position;
        // preZoomRot = transform.rotation;
    }

    void Update()
    {
        //aキー押したらターゲットをズームする
        if (Input.GetKeyDown("a")) Zoom();
    }
    public void Zoom()
    {
        isZoom = !isZoom;
        //左右移動パネルを表示、非表示切り替え
        movePanel.SetActive(!isZoom);

        if (isZoom)
        {
            //ズーム前の位置と回転を保存
            preZoomPos = transform.position;
            preZoomRot = transform.eulerAngles;
            //ターゲット前に移動してカメラを向ける
            transform.position = target.position + target.forward * 3;
            float angle = Vector3.SignedAngle(transform.forward, -target.forward, transform.up);
            transform.Rotate(0, angle, 0);
        }
        else
        {
            //ズーム前の位置と向きに変更
            transform.position = preZoomPos;
            transform.eulerAngles = preZoomRot;
        }
    }
}