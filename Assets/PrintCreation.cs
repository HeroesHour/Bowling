using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintCreation : MonoBehaviour
{
    [Tooltip("The transform to read all object-parts from, wil clone all children from this.")]
    [SerializeField] Transform targetParent;
    [Tooltip("Baseprefab: wil copy this and add all object-parts to it, then scales it down to create a miniature.")]
    [SerializeField] GameObject prefab;

    [Tooltip("Target object to create child-objects for, good for management/grouping.")]
    [SerializeField] GameObject placeParent;

    public void PrintNew()
    {
        GameObject newObject = Instantiate(prefab, placeParent.transform);
        foreach (Transform child in targetParent) child.parent = newObject.transform;
        newObject.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }
}
