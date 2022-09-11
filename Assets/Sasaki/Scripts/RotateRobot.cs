using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRobot : MonoBehaviour
{
    public float rotSpeed;
    public bool isClear;
    public GameObject hintItem;
    public Transform hintItemStartPos;
    public Transform hintItemEndPos;
    float distance;
    public static RotateRobot instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        distance = Vector3.Distance(hintItemStartPos.position, hintItemEndPos.position);
    }

    void Update()
    {
        if (!isClear || Mathf.Abs(transform.eulerAngles.y) > 0.1f)
        {
            transform.Rotate(0, rotSpeed, 0);
        }
        else
        {
            float t = (Time.time * 1.0f) * distance;
            hintItem.transform.position = Vector3.Lerp(hintItemStartPos.position, hintItemEndPos.position, t);
        }
    }
    public void ClearCheck()
    {
        isClear = true;
    }
}
