using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StickButton : MonoBehaviour
{
    //クリックしたらstickの長さを伸ばす
    //
    [SerializeField] GameObject stick;
    public int number = 1;

    public void OnClickButton()
    {
        Debug.Log("osita");
        number++;
        if (number > 3)
        {
            number = 1;
        }
        stick.transform.localScale=new Vector3(1,number*0.04f,33.33334f);
    }
}
