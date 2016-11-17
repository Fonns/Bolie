using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class DistanceSystem : MonoBehaviour
{

    public float distanceTravelled;
    Vector3 lastPosition;
    public Text scoreText;
    private int score;
    public static int dt;


    void Start()
    {
        lastPosition = transform.position;
        distanceTravelled = 0;
        score = 0;
        DontDestroyOnLoad(transform.gameObject);
    }


    void Update()
    {
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        UpdateScore();
    }

    void UpdateScore()
    {
        dt = (int)(distanceTravelled);
        scoreText.text = "Pontuação: " + Math.Round(dt * 0.03);
    }
}