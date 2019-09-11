using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class PointScript : MonoBehaviour {
    private int PlayerInt;
    int HighScoreArmStretch;

    // Use this for initialization
    public Transform PlayerLimbHead;
    public Transform BotLimbHead;
    public float ToleranceLimbHead;
    private float StartingDistanceLimbHead;
    private int LimbHeadScore = 0;

    public Transform PlayerLimbBack;
    public Transform BotLimbBack;
    public float ToleranceLimbBack;
    private float StartingDistanceLimbBack;
    private int LimbBackScore = 0;

    public Transform PlayerLimbSpine;
    public Transform BotLimbSpine;
    public float ToleranceLimbSpine;
    private float StartingDistanceLimbSpine;
    private int LimbSpineScore = 0;

    public Transform PlayerLimbRightArm;
    public Transform BotLimbRightArm;
    public float ToleranceLimbRightArm;
    private float StartingDistanceLimbRightArm;
    private int LimbRightArmScore = 0;

    public Transform PlayerLimbRightPalm;
    public Transform BotLimbRightPalm;
    public float ToleranceLimbRightPalm;
    private float StartingDistanceLimbRightPalm;
    private int LimbRightPalmScore = 0;

    public Transform PlayerLimbLeftArm;
    public Transform BotLimbLeftArm;
    public float ToleranceLimbLeftArm;
    private float StartingDistanceLimbLeftArm;
    private int LimbLeftArmScore = 0;

    public Transform PlayerLimbLeftPalm;
    public Transform BotLimbLeftPalm;
    public float ToleranceLimbLeftPalm;
    private float StartingDistanceLimbLeftPalm;
    private int LimbLeftPalmScore = 0;

    public Transform PlayerLimbRightLeg;
    public Transform BotLimbRightLeg;
    public float ToleranceLimbRightLeg;
    private float StartingDistanceLimbRightLeg;
    private int LimbRightLegScore = 0;

    public Transform PlayerLimbRightFoot;
    public Transform BotLimbRightFoot;
    public float ToleranceLimbRightFoot;
    private float StartingDistanceLimbRightFoot;
    private int LimbRightFootScore = 0;

    public Transform PlayerLimbLeftLeg;
    public Transform BotLimbLeftLeg;
    public float ToleranceLimbLeftLeg;
    private float StartingDistanceLimbLeftLeg;
    private int LimbLeftLegScore = 0;

    public Transform PlayerLimbLeftFoot;
    public Transform BotLimbLeftFoot;
    public float ToleranceLimbLeftFoot;
    private float StartingDistanceLimbLeftFoot;
    private int LimbLeftFootScore = 0;

    private int LimbScore;
    public Text Scoretext;
    private bool CountPoints = false;

    Dictionary<string, Dictionary<string, int>> playerScores;

    int changeCounter = 0;
    // Use this for initialization
    void Start()
    {
        LimbScore = 0;

        HighScoreArmStretch = PlayerPrefs.GetInt("PlayerScore", HighScoreArmStretch);
        SetScore("Previous Player " + PlayerInt, "Points", HighScoreArmStretch);


        StartingDistanceLimbHead = Vector3.Distance(BotLimbHead.position, PlayerLimbHead.position);

        StartingDistanceLimbBack = Vector3.Distance(BotLimbBack.position, PlayerLimbBack.position);

        StartingDistanceLimbSpine = Vector3.Distance(BotLimbSpine.position, PlayerLimbSpine.position);

        StartingDistanceLimbRightArm = Vector3.Distance(BotLimbRightArm.position, PlayerLimbRightArm.position);

        StartingDistanceLimbRightPalm = Vector3.Distance(BotLimbRightPalm.position, PlayerLimbRightPalm.position);

        StartingDistanceLimbLeftArm = Vector3.Distance(BotLimbLeftArm.position, PlayerLimbLeftArm.position);

        StartingDistanceLimbLeftPalm = Vector3.Distance(BotLimbLeftPalm.position, PlayerLimbLeftPalm.position);

        StartingDistanceLimbRightLeg = Vector3.Distance(BotLimbRightLeg.position, PlayerLimbRightLeg.position);

        StartingDistanceLimbRightFoot = Vector3.Distance(BotLimbRightFoot.position, PlayerLimbRightFoot.position);

        StartingDistanceLimbLeftLeg = Vector3.Distance(BotLimbLeftLeg.position, PlayerLimbLeftLeg.position);

        StartingDistanceLimbLeftFoot = Vector3.Distance(BotLimbLeftFoot.position, PlayerLimbLeftFoot.position);

    }

    private void OnDisable()
    {
        HighScoreArmStretch = LimbScore;
        PlayerPrefs.SetInt("PlayerScore", HighScoreArmStretch);
        PlayerInt = PlayerInt + 1;
    }


    void Init()
    {
        if (playerScores != null)
            return;

        playerScores = new Dictionary<string, Dictionary<string, int>>();
    }

    public void Reset()
    {
        changeCounter++;
        playerScores = null;
    }

    public int GetScore(string username, string scoreType)
    {
        Init();

        if (playerScores.ContainsKey(username) == false)
        {
            return 0;
        }

        if (playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }

        return playerScores[username][scoreType];
    }

    public void SetScore(string username, string scoreType, int value)
    {
        Init();

        changeCounter++;

        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;
    }

    public void ChangeScore(string username, string scoreType, int amount)
    {
        Init();
        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }

    public string[] GetPlayerNames()
    {
        Init();
        return playerScores.Keys.ToArray();
    }

    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();

        return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray();
    }

    public int GetChangeCounter()
    {
        return changeCounter;
    }

    public void DEBUG_ADD_POINT_TO_PLAYER()
    {
        ChangeScore("Player 1", "Points", 1);
    }

    public void DEBUG_INITIAL_SETUP()
    {
        SetScore("Player 1", "Points", 0);
        SetScore("Player 2", "Points", 345);

        SetScore("Player 3", "Points", 1000);
        SetScore("Player 4", "Points", 14345);

        SetScore("Player 5", "Points", 3);
        SetScore("Player 6", "Points", 2);
        SetScore("Player 7", "Points", 1);


        Debug.Log(GetScore("Player 1", "Points"));
    }

    // Update is called once per frame
    void Update()
    {
        Scoretext.color = Color.red;
        Scoretext.text = LimbScore.ToString("0");
        
        if (Time.timeScale==1)
        {

            float currentdistanceHead = Vector3.Distance(BotLimbHead.position, PlayerLimbHead.position);
            float mindistHead = StartingDistanceLimbHead - ToleranceLimbHead;
            float maxdistHead = StartingDistanceLimbHead + ToleranceLimbHead;
            if (currentdistanceHead == StartingDistanceLimbHead || (currentdistanceHead >= mindistHead && currentdistanceHead <= maxdistHead))
            {
                LimbHeadScore += 10;

            }


            float currentdistanceBack = Vector3.Distance(BotLimbBack.position, PlayerLimbBack.position);
            float mindistBack = StartingDistanceLimbBack - ToleranceLimbBack;
            float maxdistBack = StartingDistanceLimbBack + ToleranceLimbBack;
            if (currentdistanceBack == StartingDistanceLimbBack || (currentdistanceBack >= mindistBack && currentdistanceBack <= maxdistBack))
            {
                LimbBackScore += 10;

            }


            float currentdistanceSpine = Vector3.Distance(BotLimbSpine.position, PlayerLimbSpine.position);
            float mindistSpine = StartingDistanceLimbSpine - ToleranceLimbSpine;
            float maxdistSpine = StartingDistanceLimbSpine + ToleranceLimbSpine;
            if (currentdistanceSpine == StartingDistanceLimbSpine || (currentdistanceSpine >= mindistSpine && currentdistanceSpine <= maxdistSpine))
            {
                LimbSpineScore += 10;

            }

            float currentdistanceRightArm = Vector3.Distance(BotLimbRightArm.position, PlayerLimbRightArm.position);
            float mindistRightArm = StartingDistanceLimbRightArm - ToleranceLimbRightArm;
            float maxdistRightArm = StartingDistanceLimbRightArm + ToleranceLimbRightArm;
            if (currentdistanceRightArm == StartingDistanceLimbRightArm || (currentdistanceRightArm >= mindistRightArm && currentdistanceRightArm <= maxdistRightArm))
            {
                LimbRightArmScore += 10;

            }


            float currentdistanceRightPalm = Vector3.Distance(BotLimbRightPalm.position, PlayerLimbRightPalm.position);
            float mindistRightPalm = StartingDistanceLimbRightPalm - ToleranceLimbRightPalm;
            float maxdistRightPalm = StartingDistanceLimbRightPalm + ToleranceLimbRightPalm;
            if (currentdistanceRightPalm == StartingDistanceLimbRightPalm || (currentdistanceRightPalm >= mindistRightPalm && currentdistanceRightPalm <= maxdistRightPalm))
            {
                LimbRightPalmScore += 10;

            }


            float currentdistanceLeftArm = Vector3.Distance(BotLimbLeftArm.position, PlayerLimbLeftArm.position);
            float mindistLeftArm = StartingDistanceLimbLeftArm - ToleranceLimbLeftArm;
            float maxdistLeftArm = StartingDistanceLimbLeftArm + ToleranceLimbLeftArm;
            if (currentdistanceLeftArm == StartingDistanceLimbLeftArm || (currentdistanceLeftArm >= mindistLeftArm && currentdistanceLeftArm <= maxdistLeftArm))
            {
                LimbLeftArmScore += 10;

            }

            float currentdistanceLeftPalm = Vector3.Distance(BotLimbLeftPalm.position, PlayerLimbLeftPalm.position);
            float mindistLeftPalm = StartingDistanceLimbLeftPalm - ToleranceLimbLeftPalm;
            float maxdistLeftPalm = StartingDistanceLimbLeftPalm + ToleranceLimbLeftPalm;
            if (currentdistanceLeftPalm == StartingDistanceLimbLeftPalm || (currentdistanceLeftPalm >= mindistLeftPalm && currentdistanceLeftPalm <= maxdistLeftPalm))
            {
                LimbLeftPalmScore += 10;

            }


            float currentdistanceRightLeg = Vector3.Distance(BotLimbRightLeg.position, PlayerLimbRightLeg.position);
            float mindistRightLeg = StartingDistanceLimbRightLeg - ToleranceLimbRightLeg;
            float maxdistRightLeg = StartingDistanceLimbRightLeg + ToleranceLimbRightLeg;
            if (currentdistanceRightLeg == StartingDistanceLimbRightLeg || (currentdistanceRightLeg >= mindistRightLeg && currentdistanceRightLeg <= maxdistRightLeg))
            {
                LimbBackScore += 10;

            }


            float currentdistanceRightFoot = Vector3.Distance(BotLimbRightFoot.position, PlayerLimbRightFoot.position);
            float mindistRightFoot = StartingDistanceLimbRightFoot - ToleranceLimbRightFoot;
            float maxdistRightFoot = StartingDistanceLimbRightFoot + ToleranceLimbRightFoot;
            if (currentdistanceRightFoot == StartingDistanceLimbRightFoot || (currentdistanceRightFoot >= mindistRightFoot && currentdistanceRightFoot <= maxdistRightFoot))
            {
                LimbRightFootScore += 10;

            }

            float currentdistanceLeftLeg = Vector3.Distance(BotLimbLeftLeg.position, PlayerLimbLeftLeg.position);
            float mindistLeftLeg = StartingDistanceLimbLeftLeg - ToleranceLimbLeftLeg;
            float maxdistLeftLeg = StartingDistanceLimbLeftLeg + ToleranceLimbLeftLeg;
            if (currentdistanceLeftLeg == StartingDistanceLimbLeftLeg || (currentdistanceLeftLeg >= mindistLeftLeg && currentdistanceLeftLeg <= maxdistLeftLeg))
            {
                LimbLeftLegScore += 10;

            }


            float currentdistanceLeftFoot = Vector3.Distance(BotLimbLeftFoot.position, PlayerLimbLeftFoot.position);
            float mindistLeftFoot = StartingDistanceLimbLeftFoot - ToleranceLimbLeftFoot;
            float maxdistLeftFoot = StartingDistanceLimbLeftFoot + ToleranceLimbLeftFoot;
            if (currentdistanceLeftFoot == StartingDistanceLimbLeftFoot || (currentdistanceLeftFoot >= mindistLeftFoot && currentdistanceBack <= maxdistLeftFoot))
            {
                LimbLeftFootScore += 10;

            }



            LimbScore = LimbHeadScore + LimbBackScore + LimbSpineScore + LimbRightArmScore + LimbRightPalmScore + LimbLeftArmScore + LimbLeftPalmScore + LimbRightLegScore + LimbRightFootScore + LimbLeftLegScore + LimbLeftFootScore;
        }
        SetScore("Player " + PlayerInt, "Points", LimbScore);
        

    }
}
