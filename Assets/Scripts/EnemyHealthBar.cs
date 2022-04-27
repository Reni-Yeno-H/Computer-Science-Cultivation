using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider slider;
    Image healthBar;
    float maxHealth = 100f;
    public static float health;
    
    void start(){
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    public void SetMaxHealth(int health) 
    {

        slider.maxValue = health;
        slider.value = health;
    }
    
    public void setHealth(int health) 
    {
        slider.value = health;
    }

/*
    Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = EnemyHealthSystem.healthAmount;
        transform.localScale = localScale;
    }
    */
}
