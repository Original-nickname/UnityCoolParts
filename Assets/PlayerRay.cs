using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public Transform pointer;
    public SelectDance CurrentSelectDance;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//new Ray(transform.position, transform.forward);
        //ray.origin = transform.position;
        //ray.direction = transform.forward;
        //Debug.DrawRay(transform.position, (Input.mousePosition - transform.position) * 100f, Color.yellow);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;

            SelectDance selectDance = hit.collider.gameObject.GetComponent<SelectDance>();
            if(selectDance)
            {
                if (CurrentSelectDance && CurrentSelectDance != selectDance)
                {
                    CurrentSelectDance.DeactivateAction();
                }
                CurrentSelectDance = selectDance;
                selectDance.ActivateAction();
            }
            else
            {
                if (CurrentSelectDance)
                {
                    CurrentSelectDance.DeactivateAction();
                    CurrentSelectDance = null;
                }
            }
        } 
        else
        {
            if (CurrentSelectDance)
            {
                CurrentSelectDance.DeactivateAction();
                CurrentSelectDance = null;
            }
        }
    }
}
