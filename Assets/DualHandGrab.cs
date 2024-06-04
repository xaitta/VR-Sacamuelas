using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DualHandGrab : XRGrabInteractable
{
    private XRBaseInteractable[] interactingHands;
    //private List<XRBaseInteractor> interactingHands = new List<XRBaseInteractor>();
        
    //protected override void OnSelectEntering(XRBaseInteractor interactor)
    //{
    //    base.OnSelectEntering(interactor);

    //    if (!interactingHands.Contains(interactor))
    //    {
    //        interactingHands.Add(interactor);
    //    }

    //    CheckDualHandGrab();
    //}

    //protected override void OnSelectExiting(XRBaseInteractor interactor)
    //{
    //    base.OnSelectExiting(interactor);

    //    if (interactingHands.Contains(interactor))
    //    {
    //        interactingHands.Remove(interactor);
    //    }

    //    CheckDualHandGrab();
    //}

    //private void CheckDualHandGrab()
    //{
    //    if (interactingHands.Count == 2)
    //    {
    //        // Acción deseada cuando ambas manos están agarrando el objeto
    //        Debug.Log("Objeto agarrado con ambas manos.");
    //    }
    //}
}
