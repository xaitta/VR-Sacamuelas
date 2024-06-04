using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astilla : MonoBehaviour
{
    public Tenazas script;
    private Transform tenazasTransform;
    public bool isGrabbed = false;

    private void Start()
    {
        tenazasTransform = script.transform;
    }

    private void Update()
    {
        Debug.Log("aaaaa" + isGrabbed);
        if (isGrabbed && script.isClosed)
        {
            Debug.Log("GrabAstilla");
            transform.position = tenazasTransform.position;
             
            transform.rotation = tenazasTransform.rotation;
        }
        else if (!script.isClosed)
        {
            isGrabbed = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Tenaza"))
        {
            if (script.isClosed)
            {
                Debug.Log("Grab");
                isGrabbed = true;
            }
        }
    }


}
