using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int score;
    //const int DEFAULT_POINTS = 1;
    //int DEFAULT_POINTS = 1;
    [SerializeField] Text scoreTxt;
    [SerializeField] Text levelTxt;
    [SerializeField] int level;
    const int SCORE_THRESHOLD_PER_LEVEL = 10;
    [SerializeField] int scoreThresholdForThisLevel;

    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        level = SceneManager.GetActiveScene().buildIndex;
        scoreThresholdForThisLevel = SCORE_THRESHOLD_PER_LEVEL * level;

        //display score
        DisplayScore();
        DisplayLevel();
    }

    // Update is called once per frame
    void Update()
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        if(score < 0){
            score = 0;
        }

        
        if(level == 12)
        {
            Reset();
        }
    }

    public void UpdateScore(int addend)
    {
        if(addend <= 0){
            score = 0;
            Reset();
        }else{

        
        score += addend;
        Debug.Log("score" + score);
        //display score
        DisplayScore();
        PersistentData.Instance.SetScore(score);

        }
        /*if (score >= scoreThresholdForThisLevel)
        {
            //move on to next level
            SceneManager.LoadScene(level + 1);
        }*/
    }

    public void UpdateScore()
    {
        //UpdateScore(DEFAULT_POINTS);
        UpdateScore(1);
    }

    public void DisplayScore()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void DisplayLevel()
    {
        int levelToDisplay = level;
        levelTxt.text = "Level " + levelToDisplay;
    }   

    public void Reset()
    {
        UpdateScore(0);
    }
}
