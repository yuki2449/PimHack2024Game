using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverBGM : MonoBehaviour
{
    AudioSource GameoverAudio;
    [SerializeField] public AudioClip GameoverBGM;                //
    void Start()
    {
        GameoverAudio = GetComponent<AudioSource>();
        GameoverAudio.PlayOneShot(GameoverBGM);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
