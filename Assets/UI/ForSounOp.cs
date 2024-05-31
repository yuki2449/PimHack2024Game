using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayScript : MonoBehaviour
{
    public GameObject audioObject;

    public void FotSounOp()
    {
        audioObject.GetComponent<AudioSource>().Play();
    }
}