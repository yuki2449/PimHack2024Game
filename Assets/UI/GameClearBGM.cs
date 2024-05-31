using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearBGM : MonoBehaviour
{
    AudioSource GameclearAudio;
    [SerializeField] public AudioClip GameclearBGM;                //
    void Start()
    {
        GameclearAudio = GetComponent<AudioSource>();
        GameclearAudio.PlayOneShot(GameclearBGM);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
