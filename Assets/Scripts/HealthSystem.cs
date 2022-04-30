using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;
    public static float healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        healthAmount = 10;
        rb = GetComponent<Rigidbody2D> ();    
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        if(healthAmount <= 0)
            Destroy (gameObject);
        

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

}
