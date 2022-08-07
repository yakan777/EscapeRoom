/*クリック（タップ）するオブジェクトにアタッチする*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ItemClick : MonoBehaviour, IPointerClickHandler
{
    public Text debugText;
    void Start()
    {
        debugText.text = "";
    }
    void Update()
    {
        //spaceキーでテキスト空っぽにする
        if (Input.GetKeyDown("space")) debugText.text = "";
    }
    //ここでオブジェクトクリック時の処理
    public void OnPointerClick(PointerEventData eventData)
    {
        debugText.text += "クリックされた\n";
    }
}
