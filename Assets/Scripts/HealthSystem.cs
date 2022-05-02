using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;
    public static float healthAmount;
    public GameObject Player;

    [SerializeField] int score = 0;
    [SerializeField] int staticScore = 0;
    [SerializeField] int totalAmountOfEnemies = 1;

    [SerializeField] Text scoreText;
    [SerializeField] Text levelText;
    [SerializeField] Text playerText;

    public int calculatedEnemies;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        staticScore = PlayerPrefs.GetInt("score");
        healthAmount = 10;
        rb = GetComponent<Rigidbody2D> ();  

        DisplayScore();
        DisplayScene();
        DisplayPlayerHealth();  
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        if(healthAmount <= 0){
            Destroy (gameObject);
        }
        if(score < 0){
            score = 0;
        }

        DisplayPlayerHealth();

    }

    public void TakeDamage(int damage)
    {
        healthAmount -= damage;
        //healthBar.setHealth(currentHealth);
        if (healthAmount >= 0)
        {
            //enemyHitAudio(isSpecialBullet);

        }
        else
        {

            //enemyDeathAudio(isSpecialBullet);

            Die();
            
            //Plane.GetComponent<Score>().IncrementScore();
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX, dirY);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("DummyPanda"))
        healthAmount -= 0.1f;
    }

    public void Die()
    {

        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //anim.SetBool("isDestroyed",true);
        //StartCoroutine(deathDelay());
        //Destroy(gameObject,2f);
        Destroy(gameObject);
        restartLevel();

    }

    public void restartLevel(){
        int level = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level);
        //SceneManager.LoadScene(Respawn);
        
    }

    public void IncrementScore(int amountKilled)
    {
        //int level = SceneManager.GetActiveScene().buildIndex;
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
            Invoke("nextScene", 2f);
        } */
        
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
        float playerHealth = healthAmount;
        // Debug.Log(playerHealth + "abc");
        // Debug.Log("before");
        playerText.text = "Health: " + playerHealth;
        // Debug.Log("after");
    }

}
