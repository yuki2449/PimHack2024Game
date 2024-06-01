using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HitPoint : MonoBehaviour
{

    AudioSource MikanAudio;
    [SerializeField] public AudioClip Mikan2BGM;
    [SerializeField] public AudioClip Mikan1BGM;
    [SerializeField] public AudioClip Mikan0BGM;

    public int DefenceHP = 3;
    [SerializeField] Image Hp1;
    [SerializeField] Image Hp2;
    [SerializeField] Image Hp3;

    bool Mikan2HP = false;
    bool Mikan1HP = false;
    bool Mikan0HP = false;

    private void Start()
    {
        MikanAudio = GetComponent<AudioSource>();
        
    }

    void Update()
    {

        if (DefenceHP == 2)
        {
            Hp1.GetComponent<Image>().enabled = false;
            if (!Mikan2HP) {
                Mikan2HP = true;
                MikanAudio.PlayOneShot(Mikan2BGM);
            }
            
        }

        if (DefenceHP == 1)
        {
            Hp2.GetComponent<Image>().enabled = false;
            if (!Mikan1HP)
            {
                Mikan1HP = true;
                MikanAudio.PlayOneShot(Mikan1BGM);
            }
        }

        if (DefenceHP == 0)
        {
            Hp3.GetComponent<Image>().enabled = false;
            if (!Mikan0HP)
            {
                Mikan0HP = true;
                MikanAudio.PlayOneShot(Mikan0BGM);
            }
            Invoke(nameof(SceneMove), 0f);
            
        }
    }
    public int DefenceHPProperty
    {
        get { return DefenceHP; }
        set { DefenceHP = value; }
    }


    void SceneMove()
    {
        SceneManager.LoadScene("GameOver");
    }

}