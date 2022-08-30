using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILesoonSlotGrid : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject slotPrefab;
    private int slotNumber = 20;

    void Start()
    {
        for (int i = 0; i < slotNumber; i++)
        {
            GameObject slotObj=Instantiate(slotPrefab,transform);

            UILessonSlot slot=slotObj.GetComponent<UILessonSlot>();
        }

    }

    // Update is called once per frame

}
