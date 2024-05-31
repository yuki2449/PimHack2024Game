using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; 
    private float timeRemaining =  10f; // ?c??????

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; //?c???????????o????????????
            int minutes = Mathf.FloorToInt(timeRemaining / 60); //?c????????????????
            int seconds = Mathf.FloorToInt(timeRemaining % 60); //?c?????????b??????
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); //00:00???`????????
        }
        else
        {
            timerText.text = "Time's up!"; 
            SceneManager.LoadScene("GameClear"); 
        }
    }
}
