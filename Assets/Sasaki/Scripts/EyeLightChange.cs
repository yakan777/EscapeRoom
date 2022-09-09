using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeLightChange : MonoBehaviour
{
    Renderer eyeRenderer;
    public Material eyeMaterial;
    public Material eyeEmiMaterial;
    public Light eyeLight;
    static bool isEmission;//発光しているか
    void Start()
    {
        eyeRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // if (Input.GetKeyDown("g"))
        // {
        //     eyeRenderer.material = isEmission ? eyeMaterial : eyeEmiMaterial;
        // }
        eyeRenderer.material = !isEmission ? eyeMaterial : eyeEmiMaterial;
        eyeLight.enabled = isEmission;
    }
    public static void EmissionEye()
    {
        isEmission = !isEmission;
    }
}
