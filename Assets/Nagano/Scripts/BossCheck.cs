using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCheck : MonoBehaviour
{
    public GameObject bossPrehab;
    public Transform bossSpawn;
    int spawnCount = 1;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player" && spawnCount > 0){
            spawnCount--;
            Instantiate(bossPrehab,bossSpawn.position,Quaternion.identity);
        }
    }
}
