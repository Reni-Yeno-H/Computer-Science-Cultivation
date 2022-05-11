using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScoreOnMenuPause : MonoBehaviour
{
    public GameObject Player;
    public GameObject controller;
    public GameObject persist;
    //[SerializeField] int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Player.GetComponent<Score>().DeadScore();
        controller.GetComponent<ScoreKeeper>().Reset(0);
        persist.GetComponent<PersistentData>().Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Player.GetComponent<Score>().DeadScore();
        controller.GetComponent<ScoreKeeper>().Reset(0);
        persist.GetComponent<PersistentData>().Reset();
    }

    /*public void ScoreReset(){
        Player.GetComponent<Score>().DeadScore();
    }*/

}
