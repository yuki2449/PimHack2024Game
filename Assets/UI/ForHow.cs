using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForHow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public void HowTOPlay()
    {
        Debug.Log("ForHow");
        SceneManager.LoadScene("How To Play");
    }
}
