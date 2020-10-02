using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2PedestalCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public PedestalCollider pedestal1;
    public PedestalCollider pedestal2;
    public PedestalCollider pedestal3;
    public PedestalCollider pedestal4;
    public PedestalCollider pedestal5;
    public PedestalCollider pedestal6;
    public PedestalCollider pedestal7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pedestal2.Activated && pedestal3.Activated && pedestal4.Activated && pedestal5.Activated && pedestal6.Activated && pedestal7.Activated)
        {

        }
    }
}
