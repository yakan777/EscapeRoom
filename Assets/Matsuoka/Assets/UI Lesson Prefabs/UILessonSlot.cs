using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILessonSlot : MonoBehaviour
{
    // Start is called before the first frame update
    private UILessonItem item;

    [SerializeField]
    private Image image;

    public UILessonItem Item { get => item; set => item = value; }
    public void UILessonSetItem(UILessonItem item)
    {
        Item = item;
        if (item != null)
        {
            image.sprite = item.itemImage;
        }
    }
}
