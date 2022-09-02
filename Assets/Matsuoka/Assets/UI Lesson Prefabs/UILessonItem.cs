using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="UILesoonItem",menuName ="UI Lesson Prefabs/Items/item")]
public class UILessonItem : ScriptableObject
{
    [SerializeField]
    public string itemName;
    [SerializeField]
    public Sprite itemImage;
}
