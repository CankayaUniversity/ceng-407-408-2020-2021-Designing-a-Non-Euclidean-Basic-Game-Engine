using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    //Vector3(1f, 0f, 0f); == BLUE SIDE
    //Vector3(-1f, 0f, 0f); == PINK SIDE
    public GameObject conPortal;


    void OnTriggerEnter(Collider c){
        GameObject target = c.gameObject;
        Teleport(target);
    }

    void Teleport(GameObject target){
        //Vector3 diff = new Vector3(1f, 0f, 0f);
        target.transform.localPosition = conPortal.transform.localPosition - transform.right * 2f;
        //target.transform.localPosition = conPortal.transform.localPosition + diff;
    }
}
