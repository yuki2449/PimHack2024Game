using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBGM : MonoBehaviour
{
    AudioSource GameoverAudio;
    [SerializeField] public AudioClip GameoverBGM;                //
    [SerializeField] public AudioClip Mikan0;
    bool HanakaraGyunyu = false;
    
    void Start()
    {
        GameoverAudio = GetComponent<AudioSource>();
        
        GameoverAudio.PlayOneShot(Mikan0);

    }

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(Charari),  1.5f);
    }

    void Charari()
    {
        if (!HanakaraGyunyu)
        {
            HanakaraGyunyu = true;
            GameoverAudio.PlayOneShot(GameoverBGM);

        }
    }
}
