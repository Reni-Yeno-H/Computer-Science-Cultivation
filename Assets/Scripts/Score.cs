using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] int staticScore = 0;
    [SerializeField] int totalAmountOfEnemies = 1;
    
    [SerializeField] Text levelText;
    [SerializeField] Text scoreText;
    [SerializeField] Text healthText;

    public GameObject Player;
    //public int Respawn;
    public int calculatedEnemies;
    //int lastScoreUncalculated;
    // Start is called before the first frame update
    void Start()
    {
        reset();
        //score = lastScoreUncalculated;
        score = PlayerPrefs.GetInt("score");
        staticScore = PlayerPrefs.GetInt("score");
        DisplayScore();
        DisplayScene();
        DisplayPlayerHealth();
    }

    // Update is called once per frame
    void Update()
    {
        if(score < 0){
            score = 0;
        }

        DisplayPlayerHealth();
    }

    public void IncrementScore(int amountKilled)
    {
        int level = SceneManager.GetActiveScene().buildIndex;
        int lastScoreUncalculated = staticScore;
        calculatedEnemies = lastScoreUncalculated + totalAmountOfEnemies;
        
        if (amountKilled < 0)
        

            Debug.Log("Invalid; amount may not be less than zero.");
        else
            //calculatedEnemies = score + totalAmountOfEnemies;
            score += amountKilled;   
            
            PlayerPrefs.SetInt("score", score);
            DisplayScore(); 
            
        /*if (score == calculatedEnemies)
        {
            missionComplete = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(missionComplete.clip, transform.position);
            Invoke("nextScene", 2f);
        } */
        if(level == 0 || level >= 11)
        {
            reset();
        }
    }

    public void IncrementScore()
    {
        IncrementScore(1);
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
        
    }

    public void DisplayScene()
    {
        int firstLevelDisplayNum = 1;
        int secondLevelDisplayNum = 2;
        int thirdLevelDisplayNum = 3;
        int fourthLevelDisplayNum = 4;
        int fifthLevelDisplayNum = 5;
        int sixthLevelDisplayNum = 6;
        int seventhLevelDisplayNum = 7;
        //int eigthLevelDisplayNum = 8;

        int sceneNum = SceneManager.GetActiveScene().buildIndex;
        //int level = SceneManager.GetActiveScene().buildIndex;
        //int levelScene = SceneManager.GetSceneAt(sceneNum);
        if (sceneNum == 1)
        {
        //levelText.text = "Level " + level;
        levelText.text = "Level " + firstLevelDisplayNum;
        }
        if (sceneNum == 2)
        {
        levelText.text = "Level " + secondLevelDisplayNum;
        }
        if (sceneNum == 3)
        {
        levelText.text = "Level " + thirdLevelDisplayNum;
        }
        /*if (sceneNum == 4) 4th is event option
        {
        
        }*/
        if (sceneNum == 5 || sceneNum == 7)
        {
        levelText.text = "Level " + fourthLevelDisplayNum;
        }
        if (sceneNum == 6 || sceneNum == 8)
        {
        levelText.text = "Level " + fifthLevelDisplayNum;
        }
        if (sceneNum == 9)
        {
        levelText.text = "Level " + sixthLevelDisplayNum;
        }
        if (sceneNum == 10)
        {
        levelText.text = "Level " + seventhLevelDisplayNum;
        }

    }

    public void DisplayPlayerHealth()
    {
        float playerHealth = HealthSystem.healthAmount;
        // Debug.Log(playerHealth + "abc");
        // Debug.Log("before");
        healthText.text = "Health: " + playerHealth;
        // Debug.Log("after");
    }
    /*public void nextScene(){
        SceneManager.LoadScene(Respawn);
    }*/
    //public void playAudio(){
    //        missionComplete = GetComponent<AudioSource>();
    //        AudioSource.PlayClipAtPoint(missionComplete.clip, transform.position);
    //}
    public void reset()
    {
        score = 0;
        PlayerPrefs.SetInt("score", score);
    }
}
