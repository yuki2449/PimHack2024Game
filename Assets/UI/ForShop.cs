using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ForShop : MonoBehaviour
{
    // Start is called before the first frame update
    void Shop()
    {
        
    }
    // Update is called once per frame
    public void ShopText()
    {
        Debug.Log("ForShop");
        SceneManager.LoadScene("Shop");
    }
}
