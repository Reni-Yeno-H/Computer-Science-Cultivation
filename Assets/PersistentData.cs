using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{

    [SerializeField] int playerScore;

    public static PersistentData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SetScore(int s)
    {
        playerScore = s;
    }

    public int GetScore()
    {
        return playerScore;
    }





}