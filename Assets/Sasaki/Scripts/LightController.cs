using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : ItemSlot
{
    [SerializeField] Light RoomLight;
    public override void ClickEffect()
    {
        audioSource.PlayOneShot(effectSE);
        EyeLightChange.EmissionEye();
        RoomLight.enabled = !RoomLight.enabled;
    }
}
