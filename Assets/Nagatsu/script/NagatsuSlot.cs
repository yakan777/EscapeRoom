using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NagatsuSlot : MonoBehaviour
{
    NagatsuItem item = default;
    [SerializeField] Image image = default;
    [SerializeField] GameObject backgroundPanel = default;

    private void Awake()
    {
        //image = GetComponent<Image>();
    }

    private void Start()
    {
        backgroundPanel.SetActive(false);
    }
    public void SetItem(NagatsuItem item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public NagatsuItem GetItem()
    {
        return item;
    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

    void UpdateImage(NagatsuItem item)
    {
        if (item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.sprite;
        }
    }

    public bool Onselected()
    {
        if (item == null)
        {
            return false;
        }
        backgroundPanel.SetActive(true);
        return true;
    }
    public void HideBgPanel()
    {
        backgroundPanel.SetActive(false);
    }



}
