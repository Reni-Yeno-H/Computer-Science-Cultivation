using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthSystem : MonoBehaviour
{
    public int playerHealth = 100;
    public GameObject playerDeathEffect;
    public AudioSource PlayerGotHitAudio;
    public AudioSource PlayerDeathAudio;
    public AudioSource MissionOver;
    //public int Respawn;
    //public int deathCounter;
    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        //PlayerPrefs.SetInt("hp", playerHealth);
        if(playerHealth > 0)
        {
            //PlayerPrefs.SetInt("hp", playerHealth);
            //enemyHitAudio(isSpecialBullet);
        if (PlayerGotHitAudio == null)
            //PlayerPrefs.SetInt("hp", playerHealth);
            PlayerGotHitAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(PlayerGotHitAudio.clip, transform.position);
        }else {
            if (PlayerDeathAudio == null)
            //PlayerPrefs.SetInt("hp", playerHealth);
            PlayerDeathAudio = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(PlayerDeathAudio.clip, transform.position);
            //killed();
            //enemyDeathAudio(isSpecialBullet);
            //Die(isSpecialBullet);
            Die();
            //SceneManager.LoadScene(Respawn);
            //Invoke("restartLevel", 1f);
            //Plane.GetComponent<Score>().IncrementScore();
            //deathCounter++;
        }
    }

    public void Die()
    {
        //deathCounter++;
        if (MissionOver == null)
            MissionOver = GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(MissionOver.clip, transform.position);
        Instantiate(playerDeathEffect, transform.position, Quaternion.identity);
        
        Destroy(gameObject);
        //StartCoroutine(Restartlevel());
        //Invoke("restartLevel", 3);
        restartLevel();
        //SceneManager.LoadScene(Respawn);

        
    }
    public void restartLevel(){
        int level = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level);
        //SceneManager.LoadScene(Respawn);
        
    }
    // IEnumerator Restartlevel(){
    //     yield return new WaitForSeconds(2f);
    //     SceneManager.LoadScene(Respawn);
    // }


}
