
using UnityEngine.SceneManagement;
using UnityEngine; // Unity�G���W���̊�{�@�\���g�p���邽�߂̖��O���
using UnityEngine.UI; // UI�v�f�iText�R���|�[�l���g�Ȃǁj���g�p���邽�߂̖��O���


public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // ?^?C?}?[???c?????????\????????????UI Text?R???|?[?l???g
    private float timeRemaining = 10f; // 5 minutes in seconds?i300?b??5???j

    private void Update()
    {
        // timeRemaining??0???????????????A?J?E???g?_?E??????????
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // ?c???????????????i???t???[?????????o?????????????????j
            int minutes = Mathf.FloorToInt(timeRemaining / 60); // ?c????????????????
            int seconds = Mathf.FloorToInt(timeRemaining % 60); // ?c?????????b??????
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); // ?????b??"00:00"?`?????\??
        }
        else
        {
            timerText.text = "Time's up!"; // �c�莞�Ԃ�0�ɂȂ����ꍇ�A"Time's up!"�ƕ\��
            SceneManager.LoadScene("GameClear");

        }
    }
}

