using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForCredit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public void Credit()
    {
        Debug.Log("ForCredit");
        SceneManager.LoadScene("Credit");
    }
}

