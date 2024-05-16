using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitPoint : MonoBehaviour
{
    float playerHP = 3;
    [SerializeField] Image Hp1;
    [SerializeField] Image Hp2;
    [SerializeField] Image Hp3;


    void Update()
    {
        // J‚ð‰Ÿ‚·‚ÆHP‚ªŒ¸‚è‚Ü‚·
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerHP -= 1;
        }

        if (playerHP == 2)
        {
            Hp1.GetComponent<Image>().enabled = false;
        }

        if (playerHP == 1)
        {
            Hp2.GetComponent<Image>().enabled = false;
        }

        if (playerHP == 0)
        {
            Hp3.GetComponent<Image>().enabled = false;
        }
    }
}