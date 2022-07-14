using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider colliderA;
    public Collider colliderB;

    void Start()
    {
        Physics.IgnoreCollision(colliderA, colliderB);
/*        for(int i = 0; i < colliderA.Length; i++)
        {
            for(int j = 0; j < colliderB.Length; j++)
            {
                Physics.IgnoreCollision(colliderA[i], colliderB[j]);
            }
        }*/
    }
}
