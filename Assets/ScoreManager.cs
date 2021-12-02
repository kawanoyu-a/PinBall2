using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager: MonoBehaviour

{
    private int Score; //���_�̕ϐ�
    public Text ScoreText; //���_�̕����̕ϐ�


    // Use this for initialization
    void Start()
    {
        Score = 0; //���_��0�ɂ���
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yobareta");
        string yourTag = collision.gameObject.tag;
        if (yourTag == "LargeStarTag")//���[�W�X�^�[�ɏՓ˂����ꍇ
        {
            Score += 10;//�X�R�A��10���Z����
        }
        if (yourTag == "SmallCloudTag")//�X���[���N���E�h�ɏՓ˂����ꍇ
        {
            Score += 20;//�X�R�A��20���Z����
        }
        if (yourTag == "LargeCloudTag")//���[�W�N���E�h�ɏՓ˂����ꍇ
        {
            Score += 30;//�X�R�A��30���Z����
        }
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score" + Score.ToString(); //ScoreText�̕�����Score:Score�̒l�ɂ���

    }
}
