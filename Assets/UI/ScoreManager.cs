using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_object = null; // Text?I?u?W?F?N?g
    public int score_num ; // ?X?R?A????
    public ScoreData Sd;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        score_num = 0;
        Sd = GameObject.Find("ScoreData").GetComponent<ScoreData>();
    }
    // ?X?V
    void Update()
    {
        // ?I?u?W?F?N?g????Text?R???|?[?l???g??????
        Text score_text = score_object.GetComponent<Text>();
        // ?e?L?X?g???\??????????????
        score_text.text = "Score:" + score_num;
    }

    private void FixedUpdate()
    {
        PlayerPrefs.SetInt("SCORE", score_num);
        PlayerPrefs.Save();
    }

    public int ScoreProperty
    {
        get { return score_num; }
        set { score_num = value; }
    }


}
