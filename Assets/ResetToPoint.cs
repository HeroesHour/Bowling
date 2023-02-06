using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToPoint : MonoBehaviour
{
    Vector3 startPos;
    Quaternion startRot;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    public void Reset()
    {
        if(TryGetComponent(out Rigidbody rb))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;

            transform.position = startPos;
            transform.rotation = startRot;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bounds") Reset();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal") Reset();
    }
}
