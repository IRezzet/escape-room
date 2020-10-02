using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject DisplayObject;
    private Renderer displayRenderer;
    private bool activated;
    private Color startcolor;
    void Start()
    {
        this.GetComponent<Renderer>();
        displayRenderer = this.GetComponent<Renderer>();
        startcolor = displayRenderer.material.GetColor("_Color");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test" + other.name);
        if (other.gameObject == DisplayObject)
        {
            displayRenderer.material.SetColor("_Color", Color.green);
            activated = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == DisplayObject)
        {
            displayRenderer.material.SetColor("_Color", startcolor);
            activated = false;
        }
    }

    public bool Activated
    {
        get { return this.activated; }
    }
        
}
