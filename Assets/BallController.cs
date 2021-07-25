using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    //スコアを表示するテキスト（追加）
    private GameObject scoreText;
    //得点（追加）
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //衝突時に呼ばれる関数
    private void OnCollisionEnter(Collision other)
    {
        //SmallStarTagに衝突した場合（追加）
        if (other.gameObject.tag == "SmallStarTag")
        {
            //スコアを加算（追加）
            this.score += 10;
            //ScoreTextに獲得した点数を表示（追加）
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //LargeStarTagに衝突した場合（追加）
        if (other.gameObject.tag == "LargeStarTag")
        {
            //スコアを加算（追加）
            this.score += 20;
            //ScoreTextに獲得した点数を表示（追加）
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //SmallCloudTagに衝突した場合（追加）
        if (other.gameObject.tag == "SmallCloudTag")
        {
            //スコアを加算（追加）
            this.score += 30;
            //ScoreTextに獲得した点数を表示（追加）
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //LargeCloudTagに衝突した場合（追加）
        if (other.gameObject.tag == "LargeCloudTag")
        {
            //スコアを加算（追加）
            this.score += 40;
            //ScoreTextに獲得した点数を表示（追加）
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
    }
}
