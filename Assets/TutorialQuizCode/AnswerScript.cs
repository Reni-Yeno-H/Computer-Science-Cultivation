using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false; 
    public TutorialQuizManager tutorialQuizManager;
    
    public GameObject Player;
    public Animator m_Animator;
    //[SerializeField] GameObject player;
    //[SerializeField] private Animator playerChange;
    //[SerializeField] private int playerState;
    //[SerializeField] private Sprite[] switchSprites;
    //[SerializeField] private Image switchImage;
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

    }
    
    void Start(){
        playerChange = player.GetComponent<Animator>();
        playerState = 0;
        switchImage = GetComponent<Button>().image;
        switchImage.sprite = switchSprites[playerState];
        gameObject.GetComponent<Button>().onClick.AddListener(TurnOnAndOff);

    }
    */
    void Start(){
        m_Animator = Player.GetComponent<Animator>();
        //m_Animator.SetTrigger("FightToStance");
        
    }

/*
    void Update()
    {
        if (m_Animator.SetTrigger("Fighting_Player"))
        {
            m_Animator.ResetTrigger("Fighting_Player");

        }

        if (m_Animator.SetTrigger("Defend_Player"))
        {
            m_Animator.ResetTrigger("Defend_Player");
        }
    }
*/
/*
    private void TurnOnAndOff(){
        //playerChange = new playerChange(1f, 1f, playerState, 1f);
        playerState = 1 - playerState;
        switchImage.sprite = switchSprites[playerState];
    }
*/
    public void Answer()
    {
        //m_Animator.ResetTrigger("Fighting_Player");
        //m_Animator.ResetTrigger("Defend_Player");
        if(isCorrect) 
        {
            //m_Animator.ResetTrigger("Defend_Player");
            Debug.Log("CorrectAnswer");
            tutorialQuizManager.correct();
            m_Animator.SetTrigger("Fighting_Player");
            //switchImage.sprite = switchSprites[playerState];
            //m_Animator.ResetTrigger("Fighting_Player");
            //m_Animator.ResetTrigger("Defend_Player");
            m_Animator.SetTrigger("FightToStance");
        }
        else 
        {
            //m_Animator.ResetTrigger("Fighting_Player");
            Debug.Log("WrongAnswer");
            tutorialQuizManager.correct();
            m_Animator.SetTrigger("Defend_Player");
            //m_Animator.ResetTrigger("Defend_Player");
            //m_Animator.ResetTrigger("Fighting_Player");
            //switchImage.sprite = switchSprites[playerState];
            //m_Animator.SetTrigger("Stance");
            m_Animator.SetTrigger("DefendToStance");
        }
       //m_Animator.SetTrigger("FightToStance");
        
    }
}
