using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 追加：Textコンポーネントのために必要

public class ForScore : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    private ScoreManager script_ScoreManager;

    void Start()
    {
        script_ScoreManager = FindObjectOfType<ScoreManager>();
        if (script_ScoreManager != null)
        {
            int DefenceHP = script_ScoreManager.ScoreProperty;
        }
        else
        {
            Debug.LogError("ScoreManagerが見つかりません！");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score_object != null)
        {
            // オブジェクトからTextコンポーネントを取得
            Text score_text = score_object.GetComponent<Text>();
            if (score_text != null)
            {
                // テキストの表示を入れ替える
                score_text.text = "Score:" + script_ScoreManager.ScoreProperty;
            }
            else
            {
                Debug.LogError("Textコンポーネントが見つかりません！");
            }
        }
        else
        {
            Debug.LogError("score_objectが設定されていません！");
        }
    }
}
