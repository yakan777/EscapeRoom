using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemZoom : MonoBehaviour
{
    [SerializeField] GameObject bgPanel = default;
    [SerializeField] Transform objParent;
    [SerializeField] GameObject zoomObj;


    private void Start()
    {
        bgPanel.SetActive(false);
    }
    public void OnClickZoom()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (ItemBox.instance.SelectedSlot())
        {
            Destroy(zoomObj);
            bgPanel.SetActive(true);
            GameObject zoomObjPrefab = ItemGenerater.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent);
        }
    }

    public void ClosePanel()
    {
        Destroy(zoomObj);
        Debug.Log("hakai");
        bgPanel.SetActive(false);
    }
}
