using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    [SerializeField] bool canShoot = true;
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] Transform arrowInteract;
    [Space]
    [SerializeField] float arrowForce = 3;
    [SerializeField] StrengthLine stringLine;
    [SerializeField] Transform grabObj;
    Vector3 startPos;
    [SerializeField] Transform rightHand;

    private void Start()
    {
        startPos = grabObj.localPosition;
    }
    void Update()
    {
        // Rotate Arrow
        arrowInteract.LookAt(transform);
    }
    public void ShootArrow()
    {
        if (!canShoot) return;
        GameObject arrow = Instantiate(arrowPrefab, arrowInteract.position, arrowInteract.rotation);
        arrow.GetComponent<Rigidbody>().AddForce(arrow.transform.forward * arrowForce * stringLine.GetDistance(), ForceMode.Impulse);
    }

    public void Begin()
    {
        grabObj.parent = rightHand;
    }
    public void End()
    {
        grabObj.parent = transform;
        grabObj.localPosition = startPos;
        ShootArrow();
    }
}
