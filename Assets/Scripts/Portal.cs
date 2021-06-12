using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject conPortal;
    public bool JustPassed;


    void OnTriggerEnter(Collider c){
        GameObject target = c.gameObject;
        Teleport(target);
    }

    void Teleport(GameObject target){
        target.transform.localPosition = conPortal.transform.localPosition - transform.right * target.transform.localScale.x - transform.up * conPortal.transform.localScale.y/1.99f;
        target.transform.Rotate(Vector3.up, 180);
        float scaling = conPortal.transform.localScale.y/transform.localScale.y; // Scale difference between portals
        target.transform.localScale = target.transform.localScale * scaling; // Scale object passing according to scale difference
    }
}
