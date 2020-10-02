using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushableButton : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer sphereRenderer;
    private bool pushed = false;
    float runtime;
    void Start()
    {
        sphereRenderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        runtime += Time.deltaTime;
        //Button going in
        if (pushed)
        {
            //float pushDistance = Mathf.Lerp(0, 1 * this.transform.localScale.y, 0.01f * Time.deltaTime);
            this.transform.localPosition = new Vector3(0, 0, 0.005f);
            sphereRenderer.material.SetColor("_Color", Color.blue);
            
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
            Debug.Log("Name: " + this.name);
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
