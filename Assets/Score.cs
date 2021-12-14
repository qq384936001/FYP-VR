using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static TMP_Text scoreText;
    public static float sec_f_playerRun = 300f;//300f
    public static int sec_playerRun = 0;
    //public Text ui;
    //public static bool part1_playerRunningtimerIsRunning = true;
    public static int score = 0;
    bool calculated_the_marks = false;
    //public Text scoreText;
    //public TextMesh scoreText2;
    //public TextMeshPro scoreText3;
    //public TMP_Text scoreText;
    //public TMP_Text timer2;

    //float StartTime = 61f;

    void Start()
    {
        scoreText = GetComponent<TMP_Text>();//find the text
        sec_playerRun = PlayerPrefs.GetInt("ScoreData", sec_playerRun);//store value in memory
        //timer2.gameObject.SetActive(false);
    }

    void Update()
    {

        scoreText.text = "Score: " + score;

        /*
        DisplayTime(sec_f_playerRun);
        if (part1_playerRunningtimerIsRunning)
        {

            if (sec_f_playerRun > 0)
            {
                sec_f_playerRun -= Time.deltaTime; //when there has time
            }
            else
            {
                Debug.Log("Time has run out!");
                sec_f_playerRun = 0;
                part1_playerRunningtimerIsRunning = false;
            }
        }
        else
        {
            //calculate the mark
            if (!calculated_the_marks)
            {
                score = (int)(sec_f_playerRun * 10);
                scoreText.text = "Score: " + score;
                //scoreText4.text = "Score: " + score.ToString();
                Debug.Log(score);
                calculated_the_marks = true;

                Part2_PlayerFindingScript.part2_playerFindingtimerIsRunning = true;
                timer2.gameObject.SetActive(true);
                gameObject.SetActive(false);
            }

        }
        */





    }


    void DisplayTime(float timeToDisplay)
    {
        //timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        scoreText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }



    public void TimegameOver()
    {
        Debug.Log("You failed");
        //ui.GetComponent<State>().setState("Well done he was saved");
    }


    public static void timeKeeper(int value)
    {
        sec_playerRun += value;
        PlayerPrefs.SetInt("ScoreData", sec_playerRun);
        PlayerPrefs.Save();
        scoreText.text = sec_playerRun.ToString();
    }

    public static void resetTime()
    {
        sec_f_playerRun = 120f;
    }


    //menu
    //
    //the time is counting

    //the heart rate is 0 

    //
}
