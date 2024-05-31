using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; 
    private float timeRemaining = 10f; // 残り時間

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; //残り時間から経過時間を引く
            int minutes = Mathf.FloorToInt(timeRemaining / 60); //残り時間を分に変換
            int seconds = Mathf.FloorToInt(timeRemaining % 60); //残り時間を秒に変換
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); //00:00の形式に変換
        }
        else
        {
            timerText.text = "Time's up!"; 
            SceneManager.LoadScene("GameClear"); 
        }
    }
}
