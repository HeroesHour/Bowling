using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] Transform centerOfMass;
    void Start()
    {
        //GetComponent<Rigidbody>().centerOfMass = centerOfMass.position;
    }

    void Update()
    {
        
    }
}
