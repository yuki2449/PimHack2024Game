using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Text scoreText; // �e�L�X�g��\�����邽�߂� Text �I�u�W�F�N�g

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        scoreText = GetComponent<Text>(); // ���g�� Text �R���|�[�l���g���擾����
        // �e�L�X�g�̕\�������ւ���
        scoreText.text = "Score:" + scoreManager.score_num;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
