using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthSystem : MonoBehaviour
{
    //public int maxHealth = 3;
    //public int currentHealth;
    //public EnemyHealthBar healthBar;
    Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;
    public static float healthAmount;
    public GameObject NextSceneButton;
    public GameObject Player;
    public GameObject DesertWorm;
    public GameObject ScaryTree;
    public GameObject Yeti;
    public GameObject Dragon;
    public GameObject Boss;
    //bool isDead = false;
    //public int Respawn;
    //public int health;

    [SerializeField] GameObject controller;

    // Start is called before the first frame update
    
    void Start()
    {
        DesertWorm = GameObject.FindGameObjectWithTag("DesertWorm");
        ScaryTree = GameObject.FindGameObjectWithTag("ScaryTree");
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
        //health=100;
        healthAmount = 5;
        if(DesertWorm != null){
            healthAmount = 4;
        }

        if(ScaryTree != null){
            healthAmount = 3;
        }

        if(Yeti != null){
            healthAmount = 3;
        }
        
        if(Dragon != null){
            healthAmount = 7;
        }

        if(Boss != null){
            healthAmount = 8;
        }

        rb = GetComponent<Rigidbody2D> ();  
        //NextSceneButton.SetActive(false);
        //healthAmount = 20; 
        if (Player == null)
            Player = GameObject.FindGameObjectWithTag("MaleCharacter");
        
    }
    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        if (healthAmount <= 0)
            Die();
        //if (isDead == true)
            
            //Debug.Log("Map Enemy Dead.");
    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("SwordProjectile"))
            healthAmount -= 1;
    }

    /*public void nextScene(){
        SceneManager.LoadScene(Respawn);
    }*/

    /*void Start()
    {
        rb = GetComponent<Rigidbody2D> ();  
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }*/


    /*void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
        if(hitInfo.gameObject.tag == "Player"){
        //Healthbar health = transform.GetComponent<HealthBar>();//there can be a problem with the script
        //Healthbar is name of last sript
            //PlayerHealthSystem playerHealth = hitInfo.GetComponent<PlayerHealthSystem>();
            if (playerHealth != null){
            playerHealth.TakeDamage(touchDamage);
            //TakeDamage it is a void in HealthBar script
            }
        }
    }*/

    public void TakeDamage(int damage)
    {
        healthAmount -= damage;
        //healthBar.setHealth(currentHealth);
        /*if (healthAmount >= 0)
        {
            //enemyHitAudio(isSpecialBullet);

        }
        else
        {

            //enemyDeathAudio(isSpecialBullet);

            
            Player.GetComponent<Score>().IncrementScore();
            Die();
            //Plane.GetComponent<Score>().IncrementScore();
        }*/
        if(healthAmount <= 0){
            Die();
            Player.GetComponent<Score>().IncrementScore();
            //controller.GetComponent<ScoreKeeper>().UpdateScore();
            Player.GetComponent<ScoreKeeper>().UpdateScore();
            //Update score for persistent data
        }
    }

    public void Die()
    {

        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //anim.SetBool("isDestroyed",true);
        //StartCoroutine(deathDelay());
        //Destroy(gameObject,2f);
        Destroy(gameObject);
        NextSceneButton.gameObject.SetActive(true);

    }


}
