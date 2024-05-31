using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // �ǉ��FText�R���|�[�l���g�̂��߂ɕK�v

public class ForScore : MonoBehaviour
{
    public GameObject score_object = null; // Text�I�u�W�F�N�g
    private ScoreManager script_ScoreManager;

    void Start()
    {
        script_ScoreManager = FindObjectOfType<ScoreManager>();
        if (script_ScoreManager != null)
        {
            int DefenceHP = script_ScoreManager.ScoreProperty;
        }
        else
        {
            Debug.LogError("ScoreManager��������܂���I");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score_object != null)
        {
            // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
            Text score_text = score_object.GetComponent<Text>();
            if (score_text != null)
            {
                // �e�L�X�g�̕\�������ւ���
                score_text.text = "Score:" + script_ScoreManager.ScoreProperty;
            }
            else
            {
                Debug.LogError("Text�R���|�[�l���g��������܂���I");
            }
        }
        else
        {
            Debug.LogError("score_object���ݒ肳��Ă��܂���I");
        }
    }
}
