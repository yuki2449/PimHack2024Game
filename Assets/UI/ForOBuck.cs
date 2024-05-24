using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForOBuck: MonoBehaviour
{
    // Start is called before the first frame update
    void BuckO()
    {
        
    }
    // Update is called once per frame
    public void Buck()
    {
        Debug.Log("ForOBuck");
        SceneManager.LoadScene("Title");
    }
}
