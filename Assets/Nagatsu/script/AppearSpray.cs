using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSpray : MonoBehaviour
{
   public GameObject spray;
   public ToiletGimck redToiletGimck;
   public ToiletGimck blueToiletGimck;
   public AudioClip sound3;
   AudioSource audioSource;

   private void Start() {
    spray.SetActive(false);
   }
   void Update()
   {
        if(redToiletGimck.isClearRed && blueToiletGimck.isClearRed){
            spray.SetActive(true);
            redToiletGimck.isClearRed=false;
            blueToiletGimck.isClearRed=false;
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(sound3);

        }
   } 
}
