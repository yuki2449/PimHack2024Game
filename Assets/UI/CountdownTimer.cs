using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; 
    private float timeRemaining = 10f; // �c�莞��

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; //�c�莞�Ԃ���o�ߎ��Ԃ�����
            int minutes = Mathf.FloorToInt(timeRemaining / 60); //�c�莞�Ԃ𕪂ɕϊ�
            int seconds = Mathf.FloorToInt(timeRemaining % 60); //�c�莞�Ԃ�b�ɕϊ�
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); //00:00�̌`���ɕϊ�
        }
        else
        {
            timerText.text = "Time's up!"; 
            SceneManager.LoadScene("GameClear"); 
        }
    }
}
