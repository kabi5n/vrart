using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabthrow : MonoBehaviour {

    // Use this for initialization
    SteamVR_TrackedController trackedController;
    GameObject grababbleObject;
    FixedJoint joint;

    void Start()
    {
        trackedController = gameObject.GetComponent<SteamVR_TrackedController>();

        if (trackedController == null)
        {
            trackedController = gameObject.AddComponent<SteamVR_TrackedController>();
        }

        trackedController.TriggerClicked += new ClickedEventHandler(DoTriggerClicked);
        trackedController.TriggerUnclicked += new ClickedEventHandler(DoTriggerUnclicked);

        joint = gameObject.GetComponent<FixedJoint>();
    }

    public void DoTriggerClicked(object sender, ClickedEventArgs e)
    {
        grab();
    }

    public void DoTriggerUnclicked(object sender, ClickedEventArgs e)
    {
        release();
    }

    void grab()
    {
        if (grababbleObject == null || joint.connectedBody != null)
        {
            return;
        }

        joint.connectedBody = grababbleObject.GetComponent<Rigidbody>();
    }

    void release()
    {
        if (joint.connectedBody == null)
        {
            return;
        }

        joint.connectedBody = null;
    }

    void OnTriggerEnter(Collider other)
    {
        grababbleObject = other.gameObject;
    }

    void OnTriggerExit(Collider other)
    {
        grababbleObject = null;
    }
}