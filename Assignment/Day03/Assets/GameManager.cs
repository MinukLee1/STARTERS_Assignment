using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    //라운드가 끝나거나 시작할때마다 띄워줄 패널
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

        //라운드를 다시 처음부터 시작하는 코드 (코루틴을 통해서 구현)
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
