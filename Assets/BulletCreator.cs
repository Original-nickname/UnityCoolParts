using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletVelocity = 20f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(
                bulletPrefab, 
                transform.position, 
                transform.rotation
            );

            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletVelocity;
        }
/*
        if (Input.GetMouseButtonDown(0))
        {

        }

        if (Input.GetButtonDown("Fire1"))
        {

        }*/
    }
}
