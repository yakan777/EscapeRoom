using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightDrop : MonoBehaviour
{
    public GameObject target;
    public float weightDistance;
    public float weightSpeed;

    void Update()
    {
        Vector2 UnityChan  = target.transform.position;
        float dis = Vector2.Distance(UnityChan,this.transform.position);
        //Debug.Log(dis);

        if(dis < weightDistance){
            SphereGravity();
        }
    }

    void SphereGravity()
    {
        GetComponent<Rigidbody2D>().gravityScale = weightSpeed;
    }
}