using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEmission : MonoBehaviour
{
    public Light dictionalLight;
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            EyeLightChange.EmissionEye();
            dictionalLight.enabled = !dictionalLight.enabled;
        }
    }
}
