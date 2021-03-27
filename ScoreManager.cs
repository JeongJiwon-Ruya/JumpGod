using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int score;
    public Text ScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        ScoreDisplay.text = PlayerPrefs.GetInt("SCORE").ToString();
    }

    public void ScorePP()
    {
        score++;
        ScoreDisplay.text = score.ToString();
    }



}
