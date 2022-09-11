using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushNAZOCheck : MonoBehaviour
{
    //シングルトン化
    public static PushNAZOCheck instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public enum Eye
    {
        RED,
        BLUE
    }
    public Eye[] eyes;//目玉
    int pushCount;//押した回数
    [HideInInspector] public bool isPush;//目を押してる判定
    public bool isClear;//謎クリア判定
    const float eyePushTime = 0.5f;//目玉が凹んでる時間
    AudioSource audioSource;//オーディオソース
    //効果音
    [SerializeField] AudioClip correctSE;//正解
    [SerializeField] AudioClip missSE;//間違えた
    [SerializeField] AudioClip pushSE;//押した
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    //ロボットの目を押した時のコルーチン
    public IEnumerator PushEye(GameObject clickEye)
    {
        isPush = true;
        audioSource.PlayOneShot(pushSE);
        //押した色と現在回数の正解が合ってたら
        if ((clickEye.name == "EyeLeft" && eyes[pushCount] == Eye.RED) || (clickEye.name == "EyeRight" && eyes[pushCount] == Eye.BLUE))
        {
            pushCount++;
            Debug.Log("当たり!!");
            //最後まで目玉を押したら
            if (eyes.Length == pushCount)
            {
                yield return new WaitForSeconds(0.2f);
                Debug.Log("クリア！！");
                pushCount = 0;
                isClear = true;
                audioSource.PlayOneShot(correctSE);
                CameraMove.instance.ZoomOff();
                RotateRobot.instance.ClearCheck();
            }
            else
            {
                // audioSource.PlayOneShot(pushSE);
            }
        }
        else
        {
            pushCount = 0;
            Debug.Log("外れ");
            audioSource.PlayOneShot(missSE);
        }

        //押した時の動作(少し沈んだ後、元に戻る)
        Vector3 vec = clickEye.transform.position;
        clickEye.transform.Translate(0, 0, -0.05f);
        yield return new WaitForSeconds(eyePushTime);
        clickEye.transform.position = vec;
        isPush = false;
    }
}
