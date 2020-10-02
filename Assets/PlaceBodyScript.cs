using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBodyScript : MonoBehaviour
{
    public GameObject Head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Head.transform.position + new Vector3(0, -1.0f, 0);
    }
}
