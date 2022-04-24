using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false; 
    public TutorialQuizManager tutorialQuizManager;
    
    [SerializeField] GameObject player;
    [SerializeField] private Animator playerChange;
    [SerializeField] private int playerState;
    [SerializeField] private Sprite[] switchSprites;
    [SerializeField] private Image switchImage;
    //[SerializeField] private Animator playerChange;
    //[SerializeField] private int playerState;
    //[SerializeField] private Sprite[] switchSprites;
    //[SerializeField] Image PlayerAttack;
    //[SerializeField] Image playerDefend;
    //[SerializeField] Image switchImage;*/

    /*
    void Start(){
        playerChange = player.GetComponent<Animator>();
        playerState = 0;
        switchImage = GetComponent<Button>().image;
        switchImage.sprite = switchSprites[playerState];

    }*/
    
    void Start(){
        playerChange = player.GetComponent<Animator>();
        playerState = 0;
        switchImage = GetComponent<Button>().image;
        switchImage.sprite = switchSprites[playerState];
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

    }

    private void TurnOnAndOff(){
        //playerChange = new playerChange(1f, 1f, playerState, 1f);
        playerState = 1 - playerState;
        switchImage.sprite = switchSprites[playerState];
    }

    public void Answer()
    {
        if(isCorrect) 
        {
            
            Debug.Log("CorrectAnswer");
            tutorialQuizManager.correct();
            //switchImage.sprite = switchSprites[playerState];

        }
        else 
        {
            Debug.Log("WrongAnswer");
            tutorialQuizManager.correct();
            //switchImage.sprite = switchSprites[playerState];
        }
    }
}
