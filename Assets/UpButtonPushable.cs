using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButtonPushable : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer sphereRenderer;
    private bool pushed = false;
    float runtime;
    public GameObject elevatedObject;
    private float timepassed = 0;
    private bool up = false;
    //private bool down = false;
    //private float startTime;
    Vector3 start;
    Vector3 target;
    void Start()
    {
        sphereRenderer = this.GetComponent<Renderer>();
        start = elevatedObject.transform.localPosition;
        target = start + new Vector3(0, 76.4f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime;
        runtime += Time.deltaTime;
        //Button going in
        if (pushed)
        {
            up = true;
            //float pushDistance = Mathf.Lerp(0, 1 * this.transform.localScale.y, 0.01f * Time.deltaTime);
            this.transform.localPosition = new Vector3(0, 0, 0.005f);
            sphereRenderer.material.SetColor("_Color", Color.blue);
           
            Debug.Log("Button `B` Pressed");
            timepassed = 0;
            //start = elevatedObject.transform.localPosition;

            
            if (up == true)
            {
                Debug.Log("" + 0.1f * timepassed);
                elevatedObject.transform.localPosition = Vector3.Lerp(start, target, 0.1f * timepassed);
                if (0.1f * timepassed > 1f)
                {
                    up = false;
                    Debug.Log("false");
                }
            }

            if (runtime > 1)
            {
                pushed = false;
            }
        }
        else
        {
            this.transform.localPosition = new Vector3(0, 0, 0);
            sphereRenderer.material.SetColor("_Color", Color.red);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finger")
        {
            runtime = 0;
            pushed = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Finger")
        {
            runtime = 0;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        /*if (other.gameObject.name == "hands_coll:b_r_index3")
        {
            float pullDistance = Mathf.Lerp(0, 1 * this.transform.localScale.y, 0.1f * Time.deltaTime);
            this.transform.localPosition = new Vector3(0, -pullDistance, 0);
            sphereRenderer.material.SetColor("_Color", Color.red);
        }*/
    }

    public bool isPressed
    {
        get { return this.pushed; }
    }
}
