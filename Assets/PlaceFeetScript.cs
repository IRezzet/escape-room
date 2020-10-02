using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceFeetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Head;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(Head.transform.position.x, this.transform.position.y, Head.transform.position.z);
        if(this.transform.localPosition.y < -2)
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, -2, this.transform.localPosition.z);
            //this.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
