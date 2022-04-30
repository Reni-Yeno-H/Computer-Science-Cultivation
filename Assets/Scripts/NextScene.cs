using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void StartScene(int sceneID){
        Time.timeScale=1f;
        SceneManager.LoadScene(sceneID);
    }
}
