using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardsSecurity : MonoBehaviour
{
    public float rotationSpeed;
    public float targetY;
    private float zAngle;

    private void Start()
    {
        zAngle = transform.rotation.y;
    }
    // Update is called once per frame
    void Update()
    {
        zAngle = Mathf.MoveTowards(zAngle, targetY, Time.deltaTime * rotationSpeed);
        transform.eulerAngles = new Vector3(0, 0, zAngle);
    }
}
