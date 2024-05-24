using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ForBuck : MonoBehaviour
{
    // Start is called before the first frame update
    void BuckButton()
    {
        
    }
    // Update is called once per frame
    public void Buck()
    {
        Debug.Log("ForBuck");
        SceneManager.LoadScene("Title");
    }
}