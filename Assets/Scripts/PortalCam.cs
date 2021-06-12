using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCam : MonoBehaviour
{
    public Transform playerCam;
    public Transform portal;
    public Transform conPortal;

        // Update is called once per frame
    void Update()
    {
        Vector3 playerOffset = playerCam.position - conPortal.position;
        transform.position = portal.position + playerOffset;

        float angDiff = Quaternion.Angle(portal.rotation, conPortal.rotation);
        Quaternion portalDiff = Quaternion.AngleAxis(angDiff, Vector3.up);
        Vector3 newCam = portalDiff * playerCam.forward;
        transform.rotation = Quaternion.LookRotation(newCam, Vector3.up);

    }
}
