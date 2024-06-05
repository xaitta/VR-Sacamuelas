using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astilla : MonoBehaviour
{
    public Tenazas script;
    private Transform tenazasTransform;
    public bool isGrabbed = false;
    public bool isExtract = false;


    public Rigidbody tenazasRigidbody;
    private FixedJoint joint = null;
    public float springForce = 50f; 
    public float damper = 2f; 
    public float breakForce = 1000f;
    private Rigidbody clavoRigidbody;

    private void Start()
    {
        tenazasTransform = script.transform;
        clavoRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isGrabbed && script.isClosed)
        {
            
            transform.position = tenazasTransform.position;
            transform.position += tenazasTransform.rotation * new Vector3(0.08f, 0.03f, -0.01f);
            transform.rotation = tenazasTransform.rotation;

            transform.Rotate(-90, 0, 0);


        }
        else if(isGrabbed)
        {
            clavoRigidbody.useGravity = true;
            isGrabbed = false;
        }

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Tenaza"))
    //    {
    //        if (script.isClosed)
    //        {
    //            if (joint == null)
    //            {
    //                joint = gameObject.AddComponent<FixedJoint>();
    //                joint.connectedBody = tenazasRigidbody;

    //                joint.breakForce = breakForce;


    //                // Desactivar movimiento del clavo
    //                clavoRigidbody.isKinematic = true;


    //            }
    //        }
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Tenaza"))
        {
            if (script.isClosed)
            {
                
                isGrabbed = true;
                isExtract = true;
            }
            else
            {
                isGrabbed = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tenaza"))
        {
            if (script.isClosed)
            {
                isGrabbed = false;
                
            }
        }
    }

    //private void OnJointBreak(float a)
    //{
    //    if (a > breakForce)
    //    {
    //        Debug.Log("UwU: " + a);
    //        Destroy(joint);
    //        isExtract = true;


    //        // Desactivar movimiento del clavo
    //        clavoRigidbody.isKinematic = false;


    //    }
    //}


}
