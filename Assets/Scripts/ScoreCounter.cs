using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance;

    public Text mScoreText;
    public float mScore;
    public float mClick;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        mScoreText.text = mScore.ToString() + " $";
    }

    void Update()
    {
       
    }

    public void Count()
    {
        mScore += mClick;
        mScoreText.text = mScore.ToString() + " $";
    }
}
