using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using Random = System.Random;

public class BridgeScript : MonoBehaviour
{
    public GameObject ColorTile;
    // Start is called before the first frame update
    void Start()
    {
        List<Vector3> vectorList = generateBridge();
        foreach(Vector3 vector in vectorList)
        {
            //new Vector3(0, 0, 1), ColorTile.transform.parent.gameObject.transform.up)-90
            Vector3 rotatedVector = Quaternion.AngleAxis(Vector3.Angle(new Vector3(0, 0, 1), ColorTile.transform.parent.gameObject.transform.forward), Vector3.up) * vector;
            //Instantiate(ColorTile, ColorTile.transform.position - ColorTile.transform.up, ColorTile.transform.rotation);
            Instantiate(ColorTile, ColorTile.transform.position + rotatedVector, ColorTile.transform.rotation);
            
        }
        ColorTile.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private List<Vector3> generateBridge(){
        List<Vector3> vectorList = new List<Vector3>();
        bool done = false;
        Random rnd = new Random();
        Vector3 start = new Vector3(rnd.Next(-3, 4), 0, 1);
        vectorList.Add(start);
        Vector3 second = start + new Vector3(0, 0, 1);
        vectorList.Add(second);
        
        while (!done)
        {
            Vector3 next = new Vector3(0, 0, 0);
            Vector3 last = vectorList[vectorList.Count-1];
            int move = rnd.Next(0, 3);
            
            //Forward
            if (move == 0)
            {
                next = last + new Vector3(0, 0, 1);
            }
            //Left
            if (move == 1)
            {
                next = last + new Vector3(-1, 0, 0);
            }
            //Right
            if (move == 2)
            {
                next = last + new Vector3(1, 0, 0);
            }
            if (PossibleCheck(vectorList, next, move))
            {
                vectorList.Add(next);
                if(next.z == 9)
                {
                    done = true;
                }
            }
            
        }
        
        return vectorList;
    }

    private bool PossibleCheck(List<Vector3> vectorList, Vector3 next, int move)
    {
        if(next == new Vector3(0, 0, 0)) { return false; }
        if(next.x < -4)
        {
            return false;
        }
        if(next.x > 4)
        {
            return false;
        }
        if(vectorList.Contains(next + new Vector3(0, 0, -1)))
        {
            if(move != 0)
            {
                return false;
            }
            
        }
        if(vectorList.Contains(next))
        {
            return false;
        }
        return true;
    }

}
