using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPassCheck : MonoBehaviour
{
    public RotateDoorSA door;//ドアのスクリプト
    public bool isClear;//解除フラグ
    public static PushPassCheck instance;
    public Color[] buttons;//各ボタンの色
    public GameObject pushButtons;
    public Color[] passColors;//正解の色
    Renderer[] renderers;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip correctSE;
    [SerializeField] AudioClip pushSE;
    void Awake()
    {
        //シングルトン化
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //各ボタンの色チェック
        renderers = pushButtons.GetComponentsInChildren<Renderer>();
        //テスト中
        for (int i = 0; i < renderers.Length; i++)
        {
            buttons[i] = renderers[i].material.color;
        }
    }
    //パスワードが合ってるかチェック
    public bool passCheck()
    {
        audioSource.PlayOneShot(pushSE);
        bool passOk = true;
        for (int i = 0; i < passColors.Length; i++)
        {
            if (renderers[i].material.color != passColors[i])
            {
                passOk = false;
                // Debug.Log($"Buttos{i}:{renderers[i].material.color}");
                // Debug.Log("Pass:"+passColors[i]);
                break;
            }
        }
        if (passOk)
        {
            audioSource.PlayOneShot(correctSE);
            isClear = true;
            door.OpenDoor();
            Debug.Log("開きました");
        }
        return passOk;
    }
}
