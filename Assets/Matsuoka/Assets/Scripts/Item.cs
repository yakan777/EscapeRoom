using System;
using UnityEngine;
[Serializable]
public class Item
{

    public enum Type
    {
        Key,
        Wine,
    }

    public Type type;
    public Sprite sprite;

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite =sprite;
        
    }

}
