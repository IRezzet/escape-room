using Normal.Realtime;
using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRequest : MonoBehaviour
{

    private RealtimeView _realtimeView;
    private RealtimeTransform _realtimeTransform;
    // Start is called before the first frame update
    private void Start()
    {
        _realtimeView = gameObject.GetComponent<RealtimeView>();
        _realtimeTransform = gameObject.GetComponent<RealtimeTransform>();
    }

    private void Update() 
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)) 
        {
            _realtimeTransform.RequestOwnership();
            _realtimeView.RequestOwnership();
        }

        //while(!(OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)))
        //{
        //    if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        //     {
        //         _realtimeTransform.ClearOwnership();
        //        _realtimeView.ClearOwnership();
        //     }
        //}

        if (OVRInput.Get(OVRInput.Button.One))
        {
            _realtimeTransform.ClearOwnership();
            _realtimeView.ClearOwnership();
        }
    }
}


