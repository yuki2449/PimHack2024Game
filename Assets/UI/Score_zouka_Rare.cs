using UnityEngine;

public class Score_zouka_Rare : MonoBehaviour
{
    public ScoreManager scoreManager; // ScoreManager �N���X�̃C���X�^���X���Q�Ƃ���ϐ���錾

    private void Start()
    {
        // Start ���\�b�h���� ScoreManager �N���X�̃C���X�^���X���擾����K�v������܂�
        // �����̃I�u�W�F�N�g���� ScoreManager �R���|�[�l���g���擾���Ă���Ɖ��肵�܂�
        scoreManager = FindObjectOfType<ScoreManager>();

        // ScoreManager �N���X�̃v���p�e�B�ɃA�N�Z�X���Ēl��ύX�����
        if (scoreManager != null)
        {
            scoreManager.score_num += 500;
        }
    }
}
