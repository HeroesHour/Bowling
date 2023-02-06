using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class StrengthLine : MonoBehaviour
{
    [SerializeField] bool active = true;
    [Space]
    [SerializeField] Transform[] objects = new Transform[2];
    [SerializeField] Vector3[] positions;
    LineRenderer lr;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (!active) return;
        // Position
        positions[0] = objects[0].position;
        positions[1] = objects[1].position;
        lr.SetPositions(positions);
        // Color
        Color color = Color.white * (2 * Color.red * GetDistance());
        lr.SetColors(color, color);
    }
    public float GetDistance() { return Vector3.Distance(positions[0], positions[1]); }

    public void SetActive(bool b) { active = b; }
}
