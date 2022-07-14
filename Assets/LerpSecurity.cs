using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSecurity : MonoBehaviour
{
    public Transform Player;
    public Transform Door;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(Player.position, Door.position);

        //Передаем три значения и получаем процент
        float interpolant = Mathf.InverseLerp(3f, 2f, distance);

        //Передаем 2 значения и процент и получаем значение
        float doorAngle = Mathf.Lerp(0f, -90f, interpolant);

        Door.localEulerAngles = new Vector3(0f, 0f, doorAngle);
    }
}
