using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;

    }
    public int ScoreProperty
    {
        get { return score_num; }
        set { score_num = value; }
    }
}
