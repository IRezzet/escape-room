using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableHitboxForSpecificPlayer : MonoBehaviour
{
    public int Player;
    private Collider colliderToDisable;
    public PlayerNumberScript playerNumberScript;
    // Start is called before the first frame update
    void Start()
    {
        colliderToDisable = this.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerNumberScript.playerNumber == Player)
        {
            colliderToDisable.enabled = false;
        }
        else
        {
            colliderToDisable.enabled = true;
        }
    }
}
