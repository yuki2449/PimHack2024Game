using UnityEngine.SceneManagement;
using UnityEngine; // Unity�G���W���̊�{�@�\���g�p���邽�߂̖��O���
using UnityEngine.UI; // UI�v�f�iText�R���|�[�l���g�Ȃǁj���g�p���邽�߂̖��O���

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // �^�C�}�[�̎c�莞�Ԃ�\�����邽�߂�UI Text�R���|�[�l���g
    private float timeRemaining = 300f; // 5 minutes in seconds�i300�b��5���j

    private void Update()
    {
        // timeRemaining��0���傫���ꍇ�A�J�E���g�_�E���𑱂���
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // �c�莞�Ԃ����炷�i���t���[�����ƂɌo�߂������Ԃ������j
            int minutes = Mathf.FloorToInt(timeRemaining / 60); // �c�莞�Ԃ𕪂ɕϊ�
            int seconds = Mathf.FloorToInt(timeRemaining % 60); // �c�莞�Ԃ�b�ɕϊ�
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00"); // ���ƕb��"00:00"�`���ŕ\��
        }
        else
        {
            timerText.text = "Time's up!"; // �c�莞�Ԃ�0�ɂȂ����ꍇ�A"Time's up!"�ƕ\��
            SceneManager.LoadScene("GameClear");
        }
    }
}

