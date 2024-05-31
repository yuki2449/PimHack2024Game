using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text scoreText; // テキストを表示するための Text オブジェクト

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        scoreText = GetComponent<Text>(); // 自身の Text コンポーネントを取得する
        // テキストの表示を入れ替える
        scoreText.text = "Score:" + scoreManager.score_num;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
