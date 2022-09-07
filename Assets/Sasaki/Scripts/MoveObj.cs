using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : ItemSlot
{
    [SerializeField] Board board;

    void Update()
    {

    }
    public override void ClickEffect()
    {
        board.OpenDoor();
        Debug.Log("オーバーライド");
    }
}
