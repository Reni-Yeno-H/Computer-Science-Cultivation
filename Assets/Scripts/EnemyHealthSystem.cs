using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthSystem : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;
    public static float healthAmount;
    //public int health;

    // Start is called before the first frame update
    
    void Start()
    {
        //health=100;
        healthAmount = 1;
        rb = GetComponent<Rigidbody2D> ();  
        //healthAmount = 20;
        //rb = GetComponent<Rigidbody2D> ();    
        
    }


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

        if(healthAmount >= 0)
        {
            //enemyHitAudio(isSpecialBullet);
        
        }else {
            
            //enemyDeathAudio(isSpecialBullet);
            
            Die();
            //Plane.GetComponent<Score>().IncrementScore();
        }
    }

    public void Die()
    {
        
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //anim.SetBool("isDestroyed",true);
        //StartCoroutine(deathDelay());
        //Destroy(gameObject,2f);
        Destroy(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        if(healthAmount <= 0)
            Destroy (gameObject);
        

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX, dirY);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("SwordProjectile"))
        healthAmount -= 10.0f;
    }
    

}
