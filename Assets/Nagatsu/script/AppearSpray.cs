using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSpray : MonoBehaviour
{
   public GameObject spray;
   public ToiletGimck redToiletGimck;
   public ToiletGimck blueToiletGimck;
   private void Start() {
    spray.SetActive(false);
   }
   void Update()
   {
        if(redToiletGimck.isClearRed && blueToiletGimck.isClearRed){
            spray.SetActive(true);
            redToiletGimck.isClearRed=false;
            blueToiletGimck.isClearRed=false;

        }
   } 
}
