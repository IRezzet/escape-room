using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNumberScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int player;
    public int playerNumber
    {
        get { return player; }
        set { player = value; }
    }
    public GameObject Player
    {
        get
        {
            if (player == 1)
            {
                return GameObject.Find("Player1");
            }
            else if (player == 2)
            {
                return GameObject.Find("Player2");
            }
            else return null;
        }
    }

}
