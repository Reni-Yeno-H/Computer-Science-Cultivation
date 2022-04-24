using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerStance : MonoBehaviour
{
    public GameObject playerStanceEffect;

    /*Rigidbody2D rb;
    float dirX, dirY;
    float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();    
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX, dirY);
    }
*/
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Equals("QuestionEvent"))
        Instantiate(playerStanceEffect, transform.position, Quaternion.identity);
        
    }
}
