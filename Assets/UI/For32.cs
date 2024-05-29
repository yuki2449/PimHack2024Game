using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class For32 : MonoBehaviour
{
    private float step_time;

    // Start is called before the first frame update
    void Start()

    {
        step_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        step_time += Time.deltaTime;

        if (step_time >= 1.0f)
        {
            SceneManager.LoadScene("Scene21");
        }
    }
}
