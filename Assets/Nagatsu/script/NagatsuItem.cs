using System;
using UnityEngine;
[Serializable]

public class NagatsuItem
{
    public enum Type
    {
        Key,
        Spray,
   

    }
    public Type type;
    public Sprite sprite;
    public GameObject zoomObj;
    public NagatsuItem(Type type, Sprite sprite, GameObject zoomObj)
    {
        this.type = type;
        this.sprite =sprite;
        this.zoomObj=zoomObj;

    }

}
