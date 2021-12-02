using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager: MonoBehaviour

{
    private int Score; //得点の変数
    public Text ScoreText; //得点の文字の変数


    // Use this for initialization
    void Start()
    {
        Score = 0; //得点を0にする
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("yobareta");
        string yourTag = collision.gameObject.tag;
        if (yourTag == "LargeStarTag")//ラージスターに衝突した場合
        {
            Score += 10;//スコアに10加算する
        }
        if (yourTag == "SmallCloudTag")//スモールクラウドに衝突した場合
        {
            Score += 20;//スコアに20加算する
        }
        if (yourTag == "LargeCloudTag")//ラージクラウドに衝突した場合
        {
            Score += 30;//スコアに30加算する
        }
    }
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score" + Score.ToString(); //ScoreTextの文字をScore:Scoreの値にする

    }
}
