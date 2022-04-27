using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 60f;
    public int damage;
    public Rigidbody2D rb;
    //public AudioSource FiredAudio;
    public GameObject impactEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
            
            /*if (FiredAudio == null){
            FiredAudio = GetComponent<AudioSource>();
            }*/
    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        HealthSystem player = hitInfo.GetComponent<HealthSystem>();
        if(player != null)
        {
            player.TakeDamage(damage);
            //Destroy(gameObject);
            //enemy.enemyHitAudio(isSpecialBullet);
            //enemy.enemyDeathAudio(isSpecialBullet);
            Instantiate(impactEffect,transform.position,transform.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
        Destroy(gameObject);
        }
        //Instantiate(impactEffect,transform.position,transform.rotation);
        //Destroy(gameObject);
    }
}
