using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false; 
    public TutorialQuizManager tutorialQuizManager;
    
    public GameObject Player;
    public GameObject Enemy;
    public GameObject correct;
    public GameObject wrong;
    public GameObject BossDoubleShot;
    //public float lifetime = 5;

    public Animator PlayerAnimator;
    public Animator EnemyAnimator;
    public Animator CorrectLetteringAnimator;
    public Animator WrongLetteringAnimator;

    public Transform firePoint;

    public Transform enemyfirePoint;

    public GameObject playerWeapon;

    public GameObject enemyWeapon;
    
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
        PlayerAnimator = Player.GetComponent<Animator>();
        EnemyAnimator = Enemy.GetComponent<Animator>();
        CorrectLetteringAnimator = correct.GetComponent<Animator>();
        WrongLetteringAnimator = wrong.GetComponent<Animator>();
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
            
            CorrectLetteringAnimator.SetTrigger("CorrectPopUp");
            //m_Animator.ResetTrigger("Defend_Player");
            Debug.Log("CorrectAnswer");
            tutorialQuizManager.correct();
            PlayerAnimator.SetTrigger("Fighting_Player");
            //switchImage.sprite = switchSprites[playerState];
            //m_Animator.ResetTrigger("Fighting_Player");
            //m_Animator.ResetTrigger("Defend_Player");
            Shoot();
            //CorrectLetteringAnimator.SetTrigger("correctIdle");
            PlayerAnimator.SetTrigger("FightToStance");
            CorrectLetteringAnimator.SetTrigger("CorrectIdle");
        }
        else 
        {
            //m_Animator.ResetTrigger("Fighting_Player");
            WrongLetteringAnimator.SetTrigger("WrongPopUp");
            Debug.Log("WrongAnswer");
            tutorialQuizManager.correct();
            EnemyAnimator.SetTrigger("attack");
            EnemyAnimator.SetTrigger("idle");
            enemyShoot();
            PlayerAnimator.SetTrigger("Defend_Player");
            //m_Animator.ResetTrigger("Defend_Player");
            //m_Animator.ResetTrigger("Fighting_Player");
            //switchImage.sprite = switchSprites[playerState];
            //m_Animator.SetTrigger("Stance");
            //WrongLetteringAnimator.SetTrigger("wrongIdle");
            PlayerAnimator.SetTrigger("DefendToStance");
            WrongLetteringAnimator.SetTrigger("WrongIdle");
        }
       //m_Animator.SetTrigger("FightToStance");
        
    }

    void Shoot()
    {
        //CorrectLetteringAnimator.SetTrigger("CorrectPopUp");
        //CorrectLetteringAnimator.SetTrigger("CorrectIdle");
        //Debug.Log("Shoot");
        //Instantiate(firedSpark, firePoint.position, firePoint.rotation);
        /*if (FiredAudio == null){
                FiredAudio = GetComponent<AudioSource>();
                }*/
        GameObject sword = Instantiate(playerWeapon, firePoint.position, firePoint.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
        //sword.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        //DestroyImmediate(firedSpark, true);
        //CorrectLetteringAnimator.SetTrigger("correctIdle");
    }


    void enemyShoot()
    {
        //WrongLetteringAnimator.SetTrigger("WrongPopUp");
        //Debug.Log("Shoot");
        //Instantiate(firedSpark, firePoint.position, firePoint.rotation);
        /*if (FiredAudio == null){
                FiredAudio = GetComponent<AudioSource>();
                }*/
        GameObject enemyprojectile = Instantiate(enemyWeapon, enemyfirePoint.position, enemyfirePoint.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
        //sword.transform.SetParent (GameObject.FindGameObjectWithTag("Canvas").transform, false);
        //DestroyImmediate(firedSpark, true);
        //WrongLetteringAnimator.SetTrigger("WrongIdle");
        /*if(BossDoubleShot!= null)
        {
            lifetime -= Time.deltaTime;
            if(lifetime < 0)
            {
            enemyprojectile = Instantiate(enemyWeapon, enemyfirePoint.position, enemyfirePoint.rotation, GameObject.FindGameObjectWithTag("Canvas").transform);
            }
        }*/
    }
}
