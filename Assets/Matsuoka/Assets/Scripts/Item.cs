using System;
using UnityEngine;
[Serializable]
public class Item
{

    public enum Type
    {
        Key,
        Wine,
        LeftClipboard,
        RightClipboard,
        Room1Pass,
        Canvas,
        Disk,
    }

    public Type type;
    public Sprite sprite;
    public GameObject zoomObj;


    public Item(Type type, Sprite sprite,GameObject zoomObj)
    {
        this.type = type;
        this.sprite =sprite;
        this.zoomObj=zoomObj;

    }

}
