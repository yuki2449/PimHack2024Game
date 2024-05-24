using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForSBuck : MonoBehaviour
{
    // Start is called before the first frame update
    void Buck ()
    {
        
    }
    // Update is called once per frame
    public void BuckS()
    {
        Debug.Log("ForSBuck");
        SceneManager.LoadScene("Title");
    }
}
