using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinderMina : MonoBehaviour
{
    public float distance;
    public LayerMask layerMask;
    Color startColor;
    private void Start()
    {
        startColor = GetComponent<Renderer>().material.color;
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);

        //if (Physics.Raycast(ray, distance, layerMask))
       // {
            RaycastHit[] hit = Physics.RaycastAll(ray, distance, layerMask);
            if (hit.Length > 0) 
                GetComponent<Renderer>().material.color = Color.red;
            else
                GetComponent<Renderer>().material.color = startColor;
       // } 
       // else
      //  {
            //GetComponent<Renderer>().material.color = startColor;
      //  }
    }
}
