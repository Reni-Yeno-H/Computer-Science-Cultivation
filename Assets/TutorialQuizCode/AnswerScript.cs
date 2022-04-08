using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false; 
    public TutorialQuizManager tutorialQuizManager;

    public void Answer()
    {
        if(isCorrect) 
        {
            Debug.Log("CorrectAnswer");
            tutorialQuizManager.correct();
        }
        else 
        {
            Debug.Log("WrongAnswer");
            tutorialQuizManager.correct();
        }
    }
}
