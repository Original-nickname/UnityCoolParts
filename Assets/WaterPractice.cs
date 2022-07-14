using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPractice : MonoBehaviour
{
    public float waterDensity = 10f;
    public Transform water;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float divePercent = -(transform.position.y - water.position.y) + transform.localScale.y * 0.5f;
        divePercent = Mathf.Clamp(divePercent, 0, 1);
        rb.drag = divePercent * 2f;
        rb.angularDrag = divePercent * 2f;
        rb.AddForce(Vector3.up * divePercent * waterDensity);
    }
}
