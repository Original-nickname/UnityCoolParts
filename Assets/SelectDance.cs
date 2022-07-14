using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDance : MonoBehaviour
{
    Animator anim;
    Light mylight;
    void Awake()
    {
        anim = GetComponent<Animator>();
        mylight = GetComponentInChildren<Light>();
        DeactivateAction();
    }

    public void ActivateAction()
    {
        anim.enabled = true;
        mylight.enabled = true;
    }

    public void DeactivateAction()
    {
        anim.enabled = false;
        mylight.enabled = false;
    }
}
