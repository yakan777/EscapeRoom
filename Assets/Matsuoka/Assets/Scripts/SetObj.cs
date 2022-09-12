using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject setObject;
    [SerializeField] Item.Type useItem;
    [SerializeField] ClearDoor clearDoor;
    //選択したアイテムが適切かつオブジェクトをクリックしたら使用する
    public void OnClickObj()
    {
        bool hasItem = ItemBox.instance.TryUseItem(useItem);
        if(hasItem){
            setObject.SetActive(true);
            GetComponent<BoxCollider>().enabled=false;
            clearDoor.Count();
        }
    }

}
