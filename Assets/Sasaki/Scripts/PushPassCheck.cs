using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPassCheck : MonoBehaviour
{
    bool canOpen;
    public static PushPassCheck instance;
    public Color[] buttons;
    public GameObject pushButtons;
    public Color[] passColors;
    Renderer[] renderers;
    void Awake()
    {
        //シングルトン化
        if(instance == null){
            instance = this;
        }
    }
    void Start()
    {
        //各ボタンの色チェック
        renderers = pushButtons.GetComponentsInChildren<Renderer>();
        //テスト中
        for(int i=0;i<renderers.Length;i++){
            buttons[i] = renderers[i].material.color;
        }
    }
    //パスワードが合ってるかチェック
    public bool passCheck(){
        bool passOk = true;
        for(int i=0;i<passColors.Length;i++){
            if(renderers[i].material.color != passColors[i]){
                passOk = false;
                // Debug.Log("まだ");
                Debug.Log($"Buttos{i}:{renderers[i].material.color}");
                Debug.Log("Pass:"+passColors[i]);
                break;
            }
        }
        if(passOk)Debug.Log("開きました");
        return passOk;
    }
    public bool passCheck(Color[] colors){
        bool passOk = true;
        for(int i=0;i<passColors.Length;i++){
            if(colors[i] != passColors[i]){
                passOk = false;
                Debug.Log("まだ");
                Debug.Log(colors[i]);
                break;
            }
            passOk = true;
            Debug.Log("開きました");
        }
        return passOk;
    }
}
