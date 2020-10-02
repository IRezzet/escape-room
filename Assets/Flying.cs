using Normal.Realtime.Examples;
using Oculus.Platform.Samples.VrHoops;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flying : MonoBehaviour
{
    /*public GameObject obj;
    private float timepassed = 0;
    // Start is called before the first frame update
    void Start()
    {
        obj.GetComponent<Position>();
    }

    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime +0.02f;
        if (!(OVRInput.Get(OVRInput.Button.Two))) 
        {
            timepassed = 0;
        } 
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("Going up!: " + obj.transform.localPosition);
            obj.transform.position = new Vector3(obj.transform.position.x, timepassed, obj.transform.position.z);
        }
    }*/

    //public float speed1 = 8;
    public GameObject elevatedObject;
    private float timepassed = 0;
    private bool up = false;
    private bool down = false;
    private float startTime;
    Vector3 start;
    Vector3 target;
    Vector3 top;
    public PushableButton upbutton;
    public PushableButton downbutton;
    public PushableButton upbutton1;
    public PushableButton downbutton1;

    void Start() 
    {
        startTime = Time.time;
        start = elevatedObject.transform.localPosition;
        target = start + new Vector3(0, 75.6f, 0);
        
    }
    void Update() 
    {
        //Debug.Log(0 + Time.deltaTime);
        
        if (OVRInput.Get(OVRInput.Button.Three)) { Debug.Log("timepassed ===== 0");  timepassed = 0; }

        timepassed += Time.deltaTime;
        if (upbutton.isPressed || upbutton1.isPressed || OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("Button `B` Pressed");
            up = true;
            timepassed = 0;

        }
        if(up == true)
        {
            Debug.Log("" + 0.1f * timepassed);
            elevatedObject.transform.localPosition = Vector3.Lerp(start, target, 0.1f * timepassed);
            if (0.1f * timepassed > 1f)
            {
                up = false;
                Debug.Log("false");
            }
        }

        if (downbutton.isPressed || downbutton1.isPressed || OVRInput.Get(OVRInput.Button.Two))
        {
            top = elevatedObject.transform.localPosition;
            Debug.Log("" + downbutton.isPressed);
            timepassed = 0;
            Debug.Log("Button `X` Pressed");
            down = true;
        }

        if (down == true)
        {
            elevatedObject.transform.localPosition = Vector3.Lerp(top, start, 0.1f * timepassed);
            Debug.Log("" + elevatedObject.transform.localPosition);
            if (0.1f * timepassed > 1f)
            {
                down = false;
                Debug.Log("false");
            }
        }
    }



    /*void elevate()
    {
        //  float t = Time.time - startTime; //seconds
        timepassed += Time.deltaTime;

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            Debug.Log("Button `B` Pressed");
            moving = true;
            
        }
        while (moving == true)
        {
            elevatedObject.transform.localPosition = Vector3.Lerp(elevatedObject.transform.localPosition, new Vector3(elevatedObject.transform.localPosition.x, 55.6f, elevatedObject.transform.localPosition.z), timepassed / 50);
            if(timepassed/50 > 1)
            {
                moving = false;
            }
        }

        if (OVRInput.Get(OVRInput.Button.Four))
        {
            Debug.Log("Button `X` Pressed");
            moving = true;

            while (moving == true)
            {
                elevatedObject.transform.localPosition = Vector3.Lerp(new Vector3(elevatedObject.transform.localPosition.x, elevatedObject.transform.localPosition.y, elevatedObject.transform.localPosition.z),
                new Vector3(elevatedObject.transform.localPosition.x, -19.8f, elevatedObject.transform.localPosition.z), timepassed/500);
                moving = false;
            }
        } 
    }*/
}
