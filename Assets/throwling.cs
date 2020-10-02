using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwling : MonoBehaviour
{
    public int fallenpins = 0;
    GameObject[] pins;
    public GameObject keyCube;
    Vector3[] originalPosition = new Vector3[10];
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Script StartedTHROWLING");
        /*foreach (GameObject pin in pins) 
        {
            Debug.Log("" + pin.transform.position);
        }*/
        pins = GameObject.FindGameObjectsWithTag("Pin");
        for (int i = 0; i < pins.Length; i++)
        {
            originalPosition[i] = pins[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        fallenpins = 0;

        for (int i = 0; i < pins.Length; i++)
        {
            if (Vector3.Distance(pins[i].transform.position, originalPosition[i]) > 0.04f)
                fallenpins++;

            if (fallenpins == 10)
            {
                keyCube.SetActive(false);
                Debug.Log("All moved");
                this.enabled = false;
            }
        }

    }

}
