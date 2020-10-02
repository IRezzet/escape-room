using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalsToOpenDoors : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftDoor;
    public GameObject RightDoor;
    public GameObject Pedestal1;
    public GameObject Pedestal2;
    public GameObject Pedestal3;
    public GameObject Pedestal4;
    private PedestalCollider pedestal1Script;
    private PedestalCollider pedestal2Script;
    private PedestalCollider pedestal3Script;
    private PedestalCollider pedestal4Script;
    private bool inAnimation;
    private bool opening;
    Vector3 leftStart;
    Vector3 leftTarget;
    Vector3 rightStart;
    Vector3 rightTarget;
    float t;
    void Start()
    {
        pedestal1Script = Pedestal1.GetComponent<PedestalCollider>();
        pedestal2Script = Pedestal2.GetComponent<PedestalCollider>();
        pedestal3Script = Pedestal3.GetComponent<PedestalCollider>();
        pedestal4Script = Pedestal4.GetComponent<PedestalCollider>();
        inAnimation = false;
        leftStart = LeftDoor.transform.position;
        leftTarget = LeftDoor.transform.position + new Vector3(0, 0, -3f);
        rightStart = RightDoor.transform.position;
        rightTarget = RightDoor.transform.position + new Vector3(0, 0, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (pedestal1Script.Activated && pedestal2Script.Activated && pedestal3Script.Activated && pedestal4Script.Activated)
        {
            opening = true;
        }

        if (opening)
        {
            t += Time.deltaTime;
            LeftDoor.transform.position = Vector3.Lerp(leftStart, leftTarget, 0.2f * t);
            RightDoor.transform.position = Vector3.Lerp(rightStart, rightTarget, 0.2f * t);
        }
    }
}
