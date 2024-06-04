using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astilla : MonoBehaviour
{
    public Tenazas script;
    private Transform tenazasTransform;
    private bool isGrabbed = false;

    private void Start()
    {
        tenazasTransform = script.transform;
    }

    private void Update()
    {
        if (isGrabbed)
        {
            transform.position = tenazasTransform.position;
            transform.rotation = tenazasTransform.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tenaza"))
        {
            if (!script.isClosed)
            {
                isGrabbed = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tenaza"))
        {
            isGrabbed = false;
        }
    }
}
