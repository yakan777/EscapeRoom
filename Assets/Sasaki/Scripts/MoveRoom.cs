using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MoveRoom : MonoBehaviour,IPointerClickHandler
{
    enum MovedRoom{
        NorthRoom,
        SouthRoom,
        EastRoom,
        WestRoom,
        CentralRoom,
    }
    [SerializeField]MovedRoom nextRoom;
    public void OnPointerClick(PointerEventData eventData){
        string roomName = nextRoom.ToString();
        if(roomName != SceneManager.GetActiveScene().name){
            SceneManager.LoadScene(roomName);
            Debug.Log(roomName);
        }
    }
}
