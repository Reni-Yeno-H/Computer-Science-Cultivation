using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;
    public static float healthAmount;

    // Start is called before the first frame update
    void Start()
    {
        healthAmount = 1;
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

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX, dirY);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("DummyPanda"))
        healthAmount -= 0.1f;
    }

}
