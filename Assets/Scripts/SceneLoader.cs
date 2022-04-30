using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    /*public void btn_change_scene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }*/
    
    public void LoadScene(int level)
    { 
         SceneManager.LoadScene(level);
    }
}
