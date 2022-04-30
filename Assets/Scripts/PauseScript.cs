using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseScript;
    bool paused;
    //public GameObject scroll;
    //public Animator ScrollAnimator;

    /*void Start(){
        ScrollAnimator = scroll.GetComponent<Animator>();
        
    }*/

    void Update(){
        if(Input.GetKeyDown("p")){
            paused = !paused;

            if(paused){
                Pause();
                //ScrollAnimator.SetTrigger("ScrollEffect");
            }
            else{
                pauseScript.SetActive(false);
                Time.timeScale = 1f;
            }
            
        }
        
    }
    public void Pause()
    {
        pauseScript.SetActive(true);
        Time.timeScale = 0f;
        

    }

    public void Resume()
    {
        pauseScript.SetActive(false);
        Time.timeScale=1f;
    }
    public void Home(int sceneID){
        Time.timeScale=1f;
        SceneManager.LoadScene(sceneID);
    }
}
