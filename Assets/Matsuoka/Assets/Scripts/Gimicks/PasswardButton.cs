using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PasswardButton : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;
    public int number;

    public void OnClickPanel()
    {
        number++;
        if (number > 9)
        {
            number = 0;
        }
        numberText.text = number.ToString();
    }
}
