using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabscript : MonoBehaviour
{
    public GameObject CollidingObject;
    public GameObject objectInHand;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider other) //picking up objects with rigidbodies

    {

        if (other.gameObject.GetComponent<Rigidbody>())

        {

            CollidingObject = other.gameObject;

        }

    }

    public void OnTriggerExit(Collider other) // releasing those objects with rigidbodies

    {

        CollidingObject = null;

    }


    void Update() // refreshing program confirms trigger pressure and determines whether holding or releasing object

    {

        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.2f && CollidingObject)

        {

            GrabObject();

        }

        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") < 0.2f && objectInHand)

        {

            ReleaseObject();

        }

    }


    public void GrabObject() //create parentchild relationship between object and hand so object follows hand

    {

        objectInHand = CollidingObject;

        objectInHand.transform.SetParent(this.transform);

        objectInHand.GetComponent<Rigidbody>().isKinematic = true;

    }


    private void ReleaseObject() //removing parentchild relationship so you drop the object

    {

        objectInHand.GetComponent<Rigidbody>().isKinematic = false;

        objectInHand.transform.SetParent(null);

        objectInHand = null;

    }
 
}
