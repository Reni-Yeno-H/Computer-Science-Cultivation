using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth_Bar : MonoBehaviour
{
    Vector3 localScale;

    //EnemyHealthSystem healthBar;

    //RectTransform;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //localScale.x = healthBar.setHealth(healthBar);
        //transform.localScale = localScale;
        /*
        RectTransform.sizeDelta = Health / MaxHealth, RectTransform.sizeDelta.y;
        RectTransform.Axis.Horizontal = EnemyHealthSystem.healthAmount;
        transform.RectTransform = RectTransform;
        */
        localScale.x = EnemyHealthSystem.healthAmount;
        transform.localScale = localScale;
        //transform.localScale = localScale;
        //localScale.x = EnemyHealthSystem.currentHealth;
        //transform.localScale = localScale;
    }
}
