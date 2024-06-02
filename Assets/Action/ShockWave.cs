using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PLAYER
{


    public class ShockWave : MonoBehaviour
    {
        [SerializeField] public GameObject shockwave;
        [SerializeField] public float MAXshockD = 10.0f;
        [SerializeField] public float ShockPower = 10.0f;
        AudioSource waveaudio;
        [SerializeField] public AudioClip wavesound;
        bool waveflag = false;


        void Start()
        {
            waveaudio = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                GameObject wave = (GameObject)Instantiate(
                    shockwave,
                    transform.position,
                     Quaternion.Euler(
                            transform.parent.eulerAngles.x,
                            transform.parent.eulerAngles.y,
                            0));
                if (waveflag != true) 
                {
                    waveflag = true;
                    waveaudio.PlayOneShot(wavesound);
                    waveflag = false;
                }
                
                Rigidbody waverb = wave.GetComponent<Rigidbody>();

                Destroy(wave, 1.0f);

            }
        }
    }
}