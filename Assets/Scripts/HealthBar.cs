using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider slider;
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    void start(){
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    //void Update(){
    //    healthBar.fillAmount = health/maxHealth;
    //}

    public void SetMaxHealth(int health) 
    {

        slider.maxValue = health;
        slider.value = health;
    }
    
    public void setHealth(int health) 
    {
        slider.value = health;
    }
}
