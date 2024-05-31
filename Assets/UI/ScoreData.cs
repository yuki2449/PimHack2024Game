using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : MonoBehaviour
{
    public int score_num;
    public ScoreManager Sm;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        score_num = 0;
        Sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public int GetScore()
    {
        return Sm.score_num;
    }
}
