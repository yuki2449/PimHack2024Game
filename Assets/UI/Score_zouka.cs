using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_zouka : MonoBehaviour
{
    private ScoreManager script_ScoreManager;

    private void Start()
    {
        script_ScoreManager = FindObjectOfType<ScoreManager>();
        int DefenceHP = script_ScoreManager.ScoreProperty;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            script_ScoreManager.ScoreProperty += 100;
            Debug.Log(script_ScoreManager.ScoreProperty);
        }

        if (collision.gameObject.tag == "Rare Enemy")
        {
            script_ScoreManager.ScoreProperty += 500;
            Debug.Log(script_ScoreManager.ScoreProperty);
        }
    }
}