using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class gameoverScore : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    private static int score;
    public int highscore;

    void Start () {
        score = DistanceSystem.dt;
        
        scoreText.text = "Resultado: " + Math.Round(score * 0.03);
        
    }

    void Update () {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        if (score > highscore)
        {
            PlayerPrefs.SetInt("highscore", score);
            PlayerPrefs.Save();
        }
        highscoreText.text = "Máximo: " + Math.Round(highscore * 0.03);
    }
}
