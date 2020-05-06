using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
   

    int currentScore = 0;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = currentScore.ToString();
    }

    public void ScoreHit(int score)
    {
        currentScore = currentScore + score;
        scoreText.text = currentScore.ToString();
    }
}
