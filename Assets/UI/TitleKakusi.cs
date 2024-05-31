using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TitleKakusi : MonoBehaviour
{
    public GameObject ObjectForK;
 
    void Start()
    {
        ObjectForK.SetActive(false);
    }
 
 
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            ObjectForK.SetActive(true);
            StartCoroutine("TitleKakusi");
        }
    }
 
    IEnumerator TitleK()
    {
        for (int turn=0; turn<36; turn++)
        {
            ObjectForK.transform.Rotate(0,0,-10);
            yield return new WaitForSeconds(0.1f);
        }
    }
}