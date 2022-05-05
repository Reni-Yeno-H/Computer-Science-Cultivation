using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialQuizManager : MonoBehaviour
{
    public GameObject QuestionPanel;


    //public GameObject Player;
    //public Animator m_Animator;
    public List<QuestionAndAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;
    public GameObject NextSceneButton;

    public Text QuestionTxt;

    public void Start()
    {
        generateQuestion();
        //m_Animator = Player.GetComponent<Animator>();
    }

    public void correct()
    {
        //m_Animator.SetTrigger("Fighting_Player");
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            /*if (QnA[currentQuestion].CorrectAnswer == i)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }*/
            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
            //if(QnA[currentQuestion].Answers[2] == null || QnA[currentQuestion].Answers[3] == null){
            //    options[i].GetComponent<AnswerScript>().isCorrect = true;
            //}
        }
    }


    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        /*else if(QnA.Count == 0)
        {
            Debug.Log("Out of Questions");
            Destroy(QuestionPanel);
        }*/
        else
        {
            //Debug.Log("Delete Questions");
            Debug.Log("Out of Questions");
            Destroy(QuestionPanel);
            NextSceneButton.gameObject.SetActive(true);
        }


    }

}