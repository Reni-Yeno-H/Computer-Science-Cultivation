using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealthTextScript : MonoBehaviour
{
    [SerializeField] Text enemyText;
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        DisplayEnemyHealth();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayEnemyHealth();
    }


    public void DisplayEnemyHealth()
    {
        float enemyHealth = EnemyHealthSystem.healthAmount;
        // Debug.Log(playerHealth + "abc");
        // Debug.Log("before");
        enemyText.text = "Monster Health: " + enemyHealth;
    }
}
