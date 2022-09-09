using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushNAZOCheck : MonoBehaviour
{
    //シングルトン化
    public static PushNAZOCheck instance;
    void Awake()
    {
        if(instance == null){
            instance = this;
        }
    }

    public enum Eye{
        RED,
        BLUE
    }
    public Eye[] eyes;
    public int pushCount;
    [HideInInspector]public bool isPush;
    bool isClear;

    //ロボットの目を押した時のコルーチン
    public IEnumerator PushEye(GameObject clickEye){
        isPush =true;
        //押した色と現在回数の正解が合ってたら
        if((clickEye.name == "EyeLeft" && eyes[pushCount] == Eye.RED) || (clickEye.name == "EyeRight" && eyes[pushCount] == Eye.BLUE)){
            pushCount++;
            Debug.Log("当たり!!");
            //最後まで目玉を押したら
            if(eyes.Length == pushCount){
                Debug.Log("クリア！！");
                pushCount = 0;
                isClear = true;
            }
        }else{
            pushCount = 0;
            Debug.Log("外れ");

        }

        //押した時の動作(少し沈んだ後、元に戻る)
        Vector3 vec = clickEye.transform.position;
        clickEye.transform.Translate(0,0,-0.05f);
        yield return new WaitForSeconds(1.0f);
        clickEye.transform.position = vec;
        isPush = false;
    }
}
