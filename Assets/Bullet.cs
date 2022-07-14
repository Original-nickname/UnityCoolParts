using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject markPrefab;

    private bool isActive = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive) return;

        isActive = false;

        GetComponent<Rigidbody>().useGravity = true;

        if(collision.gameObject.tag == "BulletMask") { 
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(markPrefab, position, rotation);
        }

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
            if(collision.collider.GetComponent<EnemyHead>())
            {
                Debug.Log("Headshot"); 
            }
        }

        Douglas douglas = collision.gameObject.GetComponentInParent<Douglas>();
        if (douglas)
        {
            douglas.MakePhysical();
        }
    }
}
