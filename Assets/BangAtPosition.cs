using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    public Rigidbody targetRb;
    public float forceValue = 200f;
    public ParticleSystem ps;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            targetRb.AddForceAtPosition(transform.up * forceValue, transform.position);
            ps.Play();
        }
    }
}
