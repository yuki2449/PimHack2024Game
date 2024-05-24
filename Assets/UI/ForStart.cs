using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public void StartButton()
    {
        Debug.Log("ForStart");

        SceneManager.LoadScene("Scene32");
        

    }
}

