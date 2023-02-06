using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetSocket : XRBaseInteractable
{
    [SerializeField] IXRSelectInteractable interactable;
    [SerializeField] XRSocketInteractor socket;

    public void Reset()
    {
        Debug.Log("RESET");
        //im.ForceSelect(socket, interactable);
        interactionManager.SelectEnter(socket, interactable);
    }
    public void Detect(bool b)
    {
        if (b) Debug.Log("IN");
        else Debug.Log("OUT");
    }
}
