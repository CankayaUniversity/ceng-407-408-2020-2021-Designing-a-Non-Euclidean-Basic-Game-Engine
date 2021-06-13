using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal180 : MonoBehaviour
{
    public GameObject conPortal;
    public Transform conPlane;
    public bool onOff = true;


    void OnTriggerEnter(Collider c){
        GameObject target = c.gameObject;
        Teleport(target);
    }

    void Teleport(GameObject target){

        if(onOff){
            float scaling = conPortal.transform.localScale.y/transform.localScale.y; // Scale difference between portals
            target.transform.localScale = target.transform.localScale * scaling; // Scale object passing according to scale difference
            target.transform.position = conPortal.transform.position + conPlane.up * target.transform.localScale.x * 1.5f - conPortal.transform.up * conPortal.transform.localScale.y/1.90f;
            //target.transform.Rotate(Vector3.up, 180f);
        }


    }
}
