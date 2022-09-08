using System;
using UnityEngine;
[Serializable]

public class NagatsuItem
{
    public enum Type
    {
        Bar,
        Spray,
        RedPaper,
        BluePaper,
   

    }
    public Type type;
    public Sprite sprite;
    public GameObject zoomObj;
    public int hp;
    public NagatsuItem(Type type, Sprite sprite, GameObject zoomObj,int hp)
    {
        this.type = type;
        this.hp=hp;
        this.sprite =sprite;
        this.zoomObj=zoomObj;

    }

}
