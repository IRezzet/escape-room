using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveIfOwnerScript : MonoBehaviour
{
    public GameObject obj;
    public Animator LeftHand;
    public Animator RightHand;
    private bool isOwnedLocally
    {
        get
        {
            RealtimeView view = GetComponent<RealtimeView>();
            while (view.isChildView)
            {
                if (view.isOwnedLocally)
                    return true;

                view = view.transform.parent.GetComponent<RealtimeView>();
            }
            return view.isOwnedLocally;
        }
    }

    void Start()
    {
        Debug.Log("bool :" + isOwnedLocally);
        if (isOwnedLocally)
        {
            obj.SetActive(true);
        }
        if (!isOwnedLocally)
        {
            LeftHand.enabled = false;
            RightHand.enabled = false;
        }
    }
}
