using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ő�l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    //�X�R�A��\������e�L�X�g�i�ǉ��j
    private GameObject scoreText;
    //���_�i�ǉ��j
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������scoreText�I�u�W�F�N�g���擾�i�ǉ��j
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    //�Փˎ��ɌĂ΂��֐�
    private void OnCollisionEnter(Collision other)
    {
        //SmallStarTag�ɏՓ˂����ꍇ�i�ǉ��j
        if (other.gameObject.tag == "SmallStarTag")
        {
            //�X�R�A�����Z�i�ǉ��j
            this.score += 10;
            //ScoreText�Ɋl�������_����\���i�ǉ��j
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //LargeStarTag�ɏՓ˂����ꍇ�i�ǉ��j
        if (other.gameObject.tag == "LargeStarTag")
        {
            //�X�R�A�����Z�i�ǉ��j
            this.score += 20;
            //ScoreText�Ɋl�������_����\���i�ǉ��j
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //SmallCloudTag�ɏՓ˂����ꍇ�i�ǉ��j
        if (other.gameObject.tag == "SmallCloudTag")
        {
            //�X�R�A�����Z�i�ǉ��j
            this.score += 30;
            //ScoreText�Ɋl�������_����\���i�ǉ��j
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
        //LargeCloudTag�ɏՓ˂����ꍇ�i�ǉ��j
        if (other.gameObject.tag == "LargeCloudTag")
        {
            //�X�R�A�����Z�i�ǉ��j
            this.score += 40;
            //ScoreText�Ɋl�������_����\���i�ǉ��j
            this.scoreText.GetComponent<Text>().text = "Score" + this.score + "pt";
        }
    }
}
