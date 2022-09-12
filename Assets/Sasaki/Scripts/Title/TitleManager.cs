using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public string loadScene;
    AudioSource audioSource;
    [SerializeField]AudioClip clickSE;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
    }
    public void MoveScene(){
        StartCoroutine(SECoroutine());
    }
    IEnumerator SECoroutine(){
        audioSource.PlayOneShot(clickSE);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(loadScene);
    }
}
