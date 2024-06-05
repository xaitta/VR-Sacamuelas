using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Tenazas : MonoBehaviour
{
    public Animation anim;

    public bool isClosed = false;
    private void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => TrigTenazas());
        grabInteractable.deactivated.AddListener(x => ExitTrigTenazas());
        anim.Play("Close");
    }

    public void TrigTenazas()
    {
        if (anim != null) // Verifica si el componente de animación está asignado
        {
            anim.Play("Close"); // Reproduce la animación

            isClosed = true;
        }
    }
    public void ExitTrigTenazas()
    {
        anim.Play("Open");
        isClosed = false;
    }
}
