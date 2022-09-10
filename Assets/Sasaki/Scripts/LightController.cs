using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : ItemSlot
{
    [SerializeField] Light RoomLight;
    public override void ClickEffect()
    {
        EyeLightChange.EmissionEye();
        RoomLight.enabled = !RoomLight.enabled;
    }
}
