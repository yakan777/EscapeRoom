using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PushNAZO : MonoBehaviour, IPointerClickHandler
{
    public enum Eye
    {
        RED,
        BLUE
    }
    static bool isPush;
    public static Eye[] eyes = { Eye.BLUE, Eye.RED };
    static int count = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isPush) StartCoroutine(PushEye(eventData.pointerClick.name));
    }
    IEnumerator PushEye(string name)
    {
        isPush = true;
        //押した色判定
        //当たりならカウントを進める
        Debug.Log((int)Eye.RED);
        if ((name == "EyeRight" && eyes[count] == Eye.BLUE) || (name == "EyeLeft" && eyes[count] == Eye.RED))
        {
            count++;
            // Debug.Log("当たり");
            // Debug.Log(count);
            //全部当てたらクリア判定(カウントは０に戻す)
            if (eyes.Length == count)
            {
                Debug.Log("クリア！！カウントを0にします");
                count = 0;
                // Debug.Log(count);
            }
        }
        else
        {
            //外れたらカウントを０に戻す
            count = 0;
            Debug.Log("はずれ");
            // Debug.Log(count);
        }
        // Debug.Log(name);
        Vector3 vec = transform.localPosition;
        // Debug.Log(vec);
        transform.Translate(0, 0, -0.025f);//親のスケールによって移動距離が変わる。今回は親が0.5のスケールなので指定した数字の倍移動することになる
        // Debug.Break();
        yield return new WaitForSeconds(1.0f);
        transform.localPosition = vec;
        isPush = false;
    }
}
