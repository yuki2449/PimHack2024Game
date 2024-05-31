using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceHP : MonoBehaviour
{
    private HitPoint script_HitPoint;

    private void Start()
    {
        script_HitPoint = FindObjectOfType<HitPoint>();
        int DefenceHP = script_HitPoint.DefenceHPProperty;
        Debug.Log(DefenceHP);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            script_HitPoint.DefenceHPProperty -= 1;
            Debug.Log(script_HitPoint.DefenceHPProperty);
        }
    }
}