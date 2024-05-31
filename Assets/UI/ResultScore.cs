using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreData Sd;
    public Text tx;
    int score_num;

    private void Start()
    {
        ScoreMaster = GameObject.Find("ScoreData");
        Sd = ScoreMaster.GetComponent<ScoreData>();

        score_num = Sd.GetScore();
        tx.text = string.Format("{0}", score_num);
    }
}
