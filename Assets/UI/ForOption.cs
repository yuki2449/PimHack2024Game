using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForOption : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    public void Option()
    {
        Debug.Log("ForOption");
        Invoke("ChangeOption", 0.15f);
        
    }
    void ChangeOption()
    {
        SceneManager.LoadScene("Option");
    }
}
