using UnityEngine;

public class Score_zouka_Rare : MonoBehaviour
{
    public ScoreManager scoreManager; // ScoreManager クラスのインスタンスを参照する変数を宣言

    private void zouka()
    {
        // Start メソッド内で ScoreManager クラスのインスタンスを取得する必要があります
        // 既存のオブジェクトから ScoreManager コンポーネントを取得していると仮定します
        scoreManager = FindObjectOfType<ScoreManager>();

        // ScoreManager クラスのプロパティにアクセスして値を変更する例
        scoreManager.score_num += 500;
        
    }
}
