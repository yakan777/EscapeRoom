using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClearRoomCheck : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] string movedRoom;
    [SerializeField] string clearRoom;

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt(clearRoom, 1);
        SceneManager.LoadScene(movedRoom);
    }
}
