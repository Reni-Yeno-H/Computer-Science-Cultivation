using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestroyMusic : MonoBehaviour
{
    //GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
    //int sceneNum = SceneManager.GetActiveScene().buildIndex;

    /*void Start(){
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        int sceneNum = SceneManager.GetActiveScene().buildIndex;
        if(sceneNum == 0 || sceneNum == 10 || musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }*/
    private void Awake(){
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        int sceneNum = SceneManager.GetActiveScene().buildIndex;
        if(sceneNum != 0 || sceneNum != 10 || musicObj.Length > 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        
        Destroy(gameObject);
        
    }
}
