using UnityEngine.SceneManagement;
using UnityEngine; // Unityエンジンの基本機能を使用するための名前空間
using UnityEngine.UI; // UI要素（Textコンポーネントなど）を使用するための名前空間

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // タイマーの残り時間を表示するためのUI Textコンポーネント
    private float timeRemaining = 300f; // 5 minutes in seconds（300秒＝5分）

    private void Update()
    {
        // timeRemainingが0より大きい場合、カウントダウンを続ける
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // 残り時間を減らす（毎フレームごとに経過した時間を引く）
            int minutes = Mathf.FloorToInt(timeRemaining / 60); // 残り時間を分に変換
            int seconds = Mathf.FloorToInt(timeRemaining % 60); // 残り時間を秒に変換
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); // 分と秒を"00:00"形式で表示
        }
        else
        {
            timerText.text = "Time's up!"; // 残り時間が0になった場合、"Time's up!"と表示
            SceneManager.LoadScene("GameClear");
        }
    }
}

