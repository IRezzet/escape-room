using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceScript : MonoBehaviour
{
    Vector3 start;
    public PushableButton button1;
    public PushableButton button2;
    public PushableButton button3;
    public bool needButton1;
    public bool needButton2;
    public bool needButton3;
    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movementspeed = 0.005f;
        if(needButton1 == button1.isPressed && needButton2 == button2.isPressed && needButton3 == button3.isPressed)
        {
            movementspeed = -0.005f;
        }
        this.transform.Translate(new Vector3(0, movementspeed, 0));
        if(this.transform.position.y > start.y)
        {
            this.transform.position = start;
        }
        if (this.transform.position.y < start.y-5f)
        {
            this.transform.position = start-new Vector3(0, 5f, 0);
        }
    }
}
