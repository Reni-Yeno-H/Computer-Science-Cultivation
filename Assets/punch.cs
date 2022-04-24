using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
{
    
    //[SerializeField] GameObject laser;
    //public Transform firePoint;
    //public GameObject firedSpark;
    
    float fireRate;// = 2f;
    //float nextFire;// = Time.time;
    bool wrongAnswer;

    // Start is called before the first frame update
    void Start()
    {
        while(wrongAnswer == true){
         fireRate = 2f;
         wrongAnswer = false;
        }  
         
    }
    /*
    //Update is called once per frame
    void Update()
    {
       Invoke("CheckIfTimeToFire", 4f);
       //CheckIfTimeToFire();//player);
    }

     void CheckIfTimeToFire()//PlayerHealthSystem hitInfo)
     {
        
        if(Time.time > nextFire)//player.playerHealth != 0)
        
        {    
            Instantiate(firedSpark, firePoint.position, Quaternion.identity);
            Instantiate(laser, firePoint.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
          
        }

    }*/
}
