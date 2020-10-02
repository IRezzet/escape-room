using Normal.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEditor;
using UnityEngine;

public class AssignPlayersScript : MonoBehaviour
{
    public RealtimeAvatarManager realtimeAvatarManager;
    private GameObject Player1;
    private GameObject Player2;
    public PlayerNumberScript PlayerNumber;
    public Material red;
    public Material blue;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        realtimeAvatarManager.avatarCreated += RealtimeAvatarManager_avatarCreated;
    }

    // Update is called once per frame
    void Update()
    {
        //realtimeAvatarManager.avatarCreated += RealtimeAvatarManager_avatarCreated;
        /*
        if(realtimeAvatarManager.avatars.ContainsKey(0))
        {
            Player1 = realtimeAvatarManager.avatars[0].gameObject;
            Player1.name = "Player1";
            foreach (SkinnedMeshRenderer rend in Player1.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                rend.material = blue;
            }
        }
        if (realtimeAvatarManager.avatars.ContainsKey(1))
        {

            Player2 = realtimeAvatarManager.avatars[1].gameObject;
            Player2.name = "Player2";
            foreach (SkinnedMeshRenderer rend in Player2.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                rend.material = red;
            }
        }
        if(realtimeAvatarManager.localAvatar.gameObject.name == "Player1")
        {
            Debug.Log("You are Player1");
            PlayerNumber.playerNumber = 1;
        }
        if (realtimeAvatarManager.localAvatar.gameObject.name == "Player2")
        {
            Debug.Log("You are Player2");
            PlayerNumber.playerNumber = 2;
        }
        */
    }

    private void RealtimeAvatarManager_avatarCreated(RealtimeAvatarManager avatarManager, RealtimeAvatar avatar, bool isLocalAvatar)
    {
        if (realtimeAvatarManager.avatars.ContainsKey(0))
        {
            Player1 = realtimeAvatarManager.avatars[0].gameObject;
            Player1.name = "Player1";
            foreach (SkinnedMeshRenderer rend in Player1.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                rend.material = blue;
            }
        }
        if (realtimeAvatarManager.avatars.ContainsKey(1))
        {

            Player2 = realtimeAvatarManager.avatars[1].gameObject;
            Player2.name = "Player2";
            foreach (SkinnedMeshRenderer rend in Player2.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                rend.material = red;
            }
        }
        if (realtimeAvatarManager.localAvatar.gameObject.name == "Player1")
        {
            Debug.Log("You are Player1");
            PlayerNumber.playerNumber = 1;
        }
        if (realtimeAvatarManager.localAvatar.gameObject.name == "Player2")
        {
            Debug.Log("You are Player2");
            PlayerNumber.playerNumber = 2;
        }
    }
}
