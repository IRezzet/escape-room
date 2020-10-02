using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AdjustCharacterController : MonoBehaviour
{
    public CharacterController control;
    public GameObject trackedObject;
    // Start is called before the first frame update
    void Start()
    {
        trackedObject.GetComponent<Position>();
    }

    // Update is called once per frame
    void Update()
    {
        control.center = trackedObject.transform.position;
    }
}
