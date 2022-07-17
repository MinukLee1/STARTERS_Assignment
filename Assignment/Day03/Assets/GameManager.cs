using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    //���尡 �����ų� �����Ҷ����� ����� �г�
    public GameObject readyPannel;

    public Text scoreText;

    public Text bestScoreText;

    public Text messageText;

    public bool isRoundActive = false;

    private int score = 0;

    public ShooterRotator shooterRotator;
    public CamFollow cam;

    private void Awake()
    {
        instance = this;
        UpdateUI();
    }

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateBestScore();

        UpdateUI();

    }

    void UpdateBestScore()
    {
        if (GetBestScore() < score)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
        int GetBestScore()
        {
            int bestScore = PlayerPrefs.GetInt("BestScore");
            return bestScore;
        }

        
        void UpdateUI()
        {
            scoreText.text = "Score: " + score;
            bestScoreText.text = "Best Score: " + GetBestScore();
        }

    public void OnBallDestory()
    {
        UpdateUI();
        isRoundActive = false;
    }

    public void Reset()
    {
        score = 0;
        UpdateUI();

        //���带 �ٽ� ó������ �����ϴ� �ڵ� (�ڷ�ƾ�� ���ؼ� ����)
    }

    IEnumerator RoundRoutine()
    {
        //READY
        readyPannel.SetActive(true);
        cam.SetTarget(shooterRotator.transform, CamFollow.State.Idle);
        shooterRotator.enabled = false;

        isRoundActive = false;

        messageText.text = "Ready . . ";

        yield return new WaitForSeconds(3f);

        //PLAY
        isRoundActive = true;
        readyPannel.SetActive(false);
        shooterRotator.enabled = true;

        cam.SetTarget(shooterRotator.transform, CamFollow.State.Ready);

        while(isRoundActive == true)
        {
            yield return null;
        }


        //END
        readyPannel.SetActive(true);
        shooterRotator.enabled = false;

        messageText.text = "Wait For Next Round. . ";

        yield return new WaitForSeconds(3f);
        Reset();

    }
    }