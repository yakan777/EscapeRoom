using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    [SerializeField] GameObject[] colorButtons;
    public int buttonNumber=0;//0,1,2 => R,G,B
    //クリックされたらボタン切り替え
    private void Start()
    {
        for (int i = 0; i < colorButtons.Length; i++)
        {
            colorButtons[i].SetActive(false);
        }
        colorButtons[buttonNumber].SetActive(true);
    }
    public void OnClickColorButtons()
    {
        colorButtons[buttonNumber].SetActive(false);
        buttonNumber++;
        if (buttonNumber > 2)
        {
            buttonNumber = 0;
        }
        colorButtons[buttonNumber].SetActive(true);
    }
}
