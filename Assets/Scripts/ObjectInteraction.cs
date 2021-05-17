using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public Transform placement;
    public PlayerMovement player;
    public GameObject cam;

    void Update() {



        if(Input.GetKeyDown(KeyCode.F) && placement.childCount != 0){
            PutDown();
        } else if(Input.GetKeyDown(KeyCode.F) && placement.childCount == 0){
            var ray = cam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 5)){
                if(hit.transform == this.transform)
                    PickUp();

            }
        }

    }

    void PickUp() {
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<Rigidbody>().useGravity = false;
        //GetComponent<Rigidbody>().freezeRotation = true;
        this.transform.position = placement.position;
        this.transform.parent = GameObject.Find("Object").transform;
    }

    void PutDown() {
        this.transform.parent = null;
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<Rigidbody>().isKinematic = false;
        //GetComponent<Rigidbody>().useGravity = true;
        //GetComponent<Rigidbody>().freezeRotation = false;
    }
}
