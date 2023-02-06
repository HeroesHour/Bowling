using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class ConstantLine : MonoBehaviour
{
    [SerializeField] bool active = true;
    [Space]
    [SerializeField] Transform[] objects;
    [SerializeField] Vector3[] positions;
    LineRenderer lr;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (!active) return;
        for (int i = 0; i < objects.Length; i++)
        {
            positions[i] = objects[i].position;
        }
        lr.SetPositions(positions);
    }
}
