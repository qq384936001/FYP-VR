using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PickupObject : MonoBehaviour
{
    public SteamVR_Input_Sources type;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grab;
    GameObject collidingObject;
    GameObject onHandObj;

    private void SetCollidingObject(Collider collider)
    {
        if (collidingObject || !collider.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject = collider.gameObject;
    }

    public void OnTriggerEnter(Collider collider)
    {
        SetCollidingObject(collider);
        print("OnTriggerEnter " + collider.gameObject.name);
    }

    public void OnTriggerStay(Collider collider)
    {
        SetCollidingObject(collider);
        print("OnTriggerStay " + collider.gameObject.name);
    }

    public void OnTriggerExit(Collider collider)
    {
        if (!collidingObject)
        {
            return;
        }

        collidingObject = null;
        print("OnTriggerExit " + collider.gameObject.name);
    }

    void Update()
    {

    }
}

