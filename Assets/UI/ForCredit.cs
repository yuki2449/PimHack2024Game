using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForCredit : MonoBehaviour
{
    // Start is called before the first frame update
    void Credit()
    {
        
    }
    // Update is called once per frame
    public void CreditButton()
    {
        Debug.Log("ForCredit");
        Invoke("ChangeCredit",0.15f);
    }

    void ChangeCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}

