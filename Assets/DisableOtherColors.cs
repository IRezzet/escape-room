using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOtherColors : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerNumberScript playerNumberScript;
    private GameObject[] objectsToDisable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNumberScript.playerNumber == 1)
        {
            objectsToDisable = GameObject.FindGameObjectsWithTag("RedToDisable");
        }
        if (playerNumberScript.playerNumber == 2)
        {
            objectsToDisable = GameObject.FindGameObjectsWithTag("BlueToDisable");
        }
        if(objectsToDisable != null)
        {
            foreach (GameObject obj in objectsToDisable)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
            }
        }
        
        
    }
}
