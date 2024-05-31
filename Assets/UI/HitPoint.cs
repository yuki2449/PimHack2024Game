using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HitPoint : MonoBehaviour
{
    public int DefenceHP = 3;
    [SerializeField] Image Hp1;
    [SerializeField] Image Hp2;
    [SerializeField] Image Hp3;


    void Update()
    {

        if (DefenceHP == 2)
        {
            Hp1.GetComponent<Image>().enabled = false;
        }

        if (DefenceHP == 1)
        {
            Hp2.GetComponent<Image>().enabled = false;
        }

        if (DefenceHP == 0)
        {
            Hp3.GetComponent<Image>().enabled = false;
            SceneManager.LoadScene("GameOver");
        }
    }
    }
    public int DefenceHPProperty
    {
        get { return DefenceHP; }
        set { DefenceHP = value; }
    }
}