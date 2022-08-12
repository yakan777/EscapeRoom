using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCon3 : MonoBehaviour {
    //被写体とカメラの距離
    public float distance = 5f;
    //y軸回転の初期値 (Unitychanを前から見る）
    public float rotY = 180f;
    //x軸回転の初期値
    public float rotX = 0f;
    //ドラッグの距離に対する角度変化の度合い(画面幅で360度)
    public float rotAngle = 360f;
    //映す対象(Unitychan)が入る
    public Transform target;
    //注視点のオフセット（上方にして顔などに合わせる)
    public Vector3 offset;

    //ドラッグを始めた地点
    Vector2 slideStartPos;
    //前フレームのマウスの位置
    Vector2 prevPos;
    //前フレームと現在のマウス位置のずれ量(x,y)
    Vector2 delta;
    //ドラッグ中か？
    bool isDrag = false;

    //fieldOfView:ズーム値の初期値
    float fov = 60f;

    void Update() {
        /**ドラッグの決定**/
        //カチっとマウスを「押し下げ」された
        if (Input.GetMouseButtonDown(0)) {
            slideStartPos = Input.mousePosition;//座標を記録
        }
        //マウスが押され続けている
        if (Input.GetMouseButton(0)) {
            //もし画面幅の1割の量動かしたらドラッグとみなす
            if (Vector2.Distance(slideStartPos, Input.mousePosition) >= Screen.width * 0.1f) {
                isDrag = true;
            }
        }
        //マウスが押されていなかったらisDragはfalse
        if (!Input.GetMouseButton(0)) {
            isDrag = false;
        }

        /**ドラッグによる変位量を求める**/
        //ドラッグされていたら
        if (isDrag) {
            Vector2 pos = Input.mousePosition;
            delta = pos - prevPos;//前フレームのマウス位置との差をみる

        } else {
            delta = Vector2.zero;
        }
        prevPos = Input.mousePosition;//prevを更新

        /**マウス座標の変位量によってどれだけカメラを動かすのかを求める**/
        if (isDrag) {
            //ドラッグ量に対する感度を求める
            float anglePerPixel = rotAngle / Screen.width;
            //ドラッグの横成分はy回転
            rotY += delta.x * anglePerPixel;
            //0~360を循環
            rotY = Mathf.Repeat(rotY, 360f);
            //ドラッグの縦成分はx回転
            rotX -= delta.y * anglePerPixel;
            //-60~60に挟み込む
            rotX = Mathf.Clamp(rotX, -60f, 60f);

        }

        /**カメラ位置、カメラの角度の決定**/
        if (target != null) {
            //注視点の設定
            Vector3 lookPosition = target.position + offset;
            //カメラを動かすベクトルを作成(q*vecでベクトルを回す） 指定したQEでvectorが回転する
            Vector3 relativePos = Quaternion.Euler(rotX, rotY, 0) * new Vector3(0, 0, -distance);
            //カメラの位置を決定
            transform.position = lookPosition + relativePos;
            //注視点にカメラを向ける
            transform.LookAt(lookPosition);
        }

        /**fov(FieldOfView:ズーム)の決定**/
        //マウスホイールによってfovの値を操作
        fov -= Input.GetAxis("Mouse ScrollWheel")*5;
        //10~150に挟み込む
        fov = Mathf.Clamp(fov, 10f, 150f);
        //fovの値を決定
        Camera.main.fieldOfView = fov;
    }
}
