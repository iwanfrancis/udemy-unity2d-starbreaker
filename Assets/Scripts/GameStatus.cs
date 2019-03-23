﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour {

    // Config paramaters
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 15;
    [SerializeField] Text scoreText;

    // State variables
    [SerializeField] int currentScore = 0;

    private void Start() {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore() {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
