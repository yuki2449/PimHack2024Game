using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueguy_Bomb : MonoBehaviour
{
    AudioSource BlueAudio;
    [SerializeField] public AudioClip Bomb;
    // Start is called before the first frame update
    void Start()
    {
        BlueAudio = GetComponent<AudioSource>();
        BlueAudio.PlayOneShot(Bomb);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
