using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHandGrabb : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabbingHand);
        grabInteractable.selectExited.AddListener(ShowGrabbingHand);
    }

    //public void HideGrabbingHand(SelectEnterEventArgs args)
    //{
    //   Transform[] array =args.interactableObject.transform.GetComponents<Transform>();

    //    foreach(var a in array)
    //    {
    //        if(a.tag == "LeftHand")
    //        {
    //            leftHand.SetActive(false);
    //        }
    //        else if (a.tag == "RightHand")
    //        {
    //            rightHand.SetActive(false);
    //        }
    //    }
    //    //if (args.interactableObject.transform.GetComponentsInChildren() == "LeftHand")
    //    //{
    //    //    leftHand.SetActive(false);
    //    //}
    //    //else if (args.interactableObject.transform.tag == "RightHand")
    //    //{
    //    //    rightHand.SetActive(false);
    //    //}
    //}

    private void HideGrabbingHand(SelectEnterEventArgs args)
    {
        Debug.Log("HOOOOLAAAA" + args.interactorObject.transform.name);
        // Verificar el tag del objeto principal
        if (args.interactorObject.transform.tag == "LeftHand")
        {
            // Ejecutar acción deseada
            leftHand.SetActive(false);
        }
        else
        {
            // Si el objeto principal no tiene el tag, verifica sus hijos
            foreach (Transform child in args.interactorObject.transform)
            {
                if (child.CompareTag("LeftHand"))
                {
                    // Ejecutar acción deseada
                    leftHand.SetActive(false);
                    break; // Salir del bucle si encontramos lo que buscamos
                }
            }
        }
        if (args.interactorObject.transform.tag == "RightHand")
        {
            // Ejecutar acción deseada
            rightHand.SetActive(false);
        }
        else
        {
            // Si el objeto principal no tiene el tag, verifica sus hijos
            foreach (Transform child in args.interactorObject.transform)
            {
                if (child.CompareTag("RightHand"))
                {
                    // Ejecutar acción deseada
                    rightHand.SetActive(false);
                    break; // Salir del bucle si encontramos lo que buscamos
                }
            }
        }
    }

    public void ShowGrabbingHand(SelectExitEventArgs args)
    {
        // Verificar el tag del objeto principal
        if (args.interactorObject.transform.tag == "LeftHand")
        {
            // Ejecutar acción deseada
            leftHand.SetActive(true);
        }
        else
        {
            // Si el objeto principal no tiene el tag, verifica sus hijos
            foreach (Transform child in args.interactorObject.transform)
            {
                if (child.CompareTag("LeftHand"))
                {
                    // Ejecutar acción deseada
                    leftHand.SetActive(true);
                    break; // Salir del bucle si encontramos lo que buscamos
                }
            }
        }
        if (args.interactorObject.transform.tag == "RightHand")
        {
            // Ejecutar acción deseada
            rightHand.SetActive(true);
        }
        else
        {
            // Si el objeto principal no tiene el tag, verifica sus hijos
            foreach (Transform child in args.interactorObject.transform)
            {
                if (child.CompareTag("RightHand"))
                {
                    // Ejecutar acción deseada
                    rightHand.SetActive(true);
                    break; // Salir del bucle si encontramos lo que buscamos
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
