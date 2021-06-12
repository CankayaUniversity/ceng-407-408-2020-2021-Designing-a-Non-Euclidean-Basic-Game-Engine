using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject conPortal;
    public Transform conPlane;


    void OnTriggerEnter(Collider c){
        GameObject target = c.gameObject;
        Teleport(target);
    }

    void Teleport(GameObject target){
        /*float rotDiff = Quaternion.Angle(transform.rotation, conPortal.transform.rotation);
        Vector3 rotationDiff = new Vector3(0f, transform.rotation.y- conPortal.transform.rotation.y, 0f);
        target.transform.eulerAngles += rotationDiff;
        Vector3 positionOffset = Quaternion.Euler(0f, rotDiff, 0f) * (target.transform.position - transform.position);
        Vector3 sizeOffset = conPortal.transform.right * target.transform.localScale.x;
        target.transform.position = conPortal.transform.position + positionOffset - sizeOffset;*/

        float scaling = conPortal.transform.localScale.y/transform.localScale.y; // Scale difference between portals
        target.transform.localScale = target.transform.localScale * scaling; // Scale object passing according to scale difference
        target.transform.position = conPortal.transform.position + conPlane.up * target.transform.localScale.x * 1.5f - conPortal.transform.up * conPortal.transform.localScale.y/1.90f;

        //target.transform.position = conPortal.transform.position - conPortal.transform.right * target.transform.localScale.x - conPortal.transform.up * conPortal.transform.localScale.y/1.90f;

        //target.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        //Debug.Log(conPortal.transform.eulerAngles.y);
    }
}
