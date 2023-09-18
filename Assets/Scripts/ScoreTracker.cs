using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class ScoreTracker : MonoBehaviour



{
    //Start counter
    public int GoodCounter;
    public int BadCounter;

    public TextMeshProUGUI endingText;
    public TextMeshProUGUI CounterText;
    public GameObject ScoreUI;

    //Yarn command good score
    [YarnCommand("IncreaseGood")]
    void IncreaseGoodScore()
    {
        GoodCounter++;
        Debug.Log("good");
    }


    //Yarn command bad score
    [YarnCommand("IncreaseBad")]
    void IncreaseBadScore()
    {
        BadCounter++;
        Debug.Log("bad");
    }

    [YarnCommand("CalculateScore")]

    void CalculateScore()
    {
        float score = GoodCounter - BadCounter;
        CounterText.text = "Score: " + score;

        if(score > 0 )
        {
            endingText.text = "You make the world a better place through connection <3";
        }
        else
        {

            endingText.text = "You are on the pathway to world domination. Lesser mortals bow before you as you plant seeds of disconnection.";
        }


        ScoreUI.SetActive(true);

        //SleepTimeout(1000);
        //SceneManager.LoadScene(2);
    }
}
