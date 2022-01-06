using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text missedText;
    
    public GameObject gameOverUI;
    public TMP_Text gameOverInformation;
 
    private float timer;
    public int score;
    public int missedTargets;
 
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        missedText.text = "Allowed misses: " + missedTargets;
        missedTargets = 5;
        
        gameOverUI.SetActive(false);
    }
 
    public virtual void Update()
    {
        // add 1 point every second
        timer += Time.deltaTime;
 
        if (timer > 1f)
        {
            AddScore(1);
            timer = 0;
        }
    }
 
    public void AddScore(int addedValue)
    {
        // add score when hitting a target
        score += addedValue;
        scoreText.text = "Score: " + score;
    }
    
    public void AllowedMisses(int subValue) // missing targets will be punished
    {
        missedTargets -= subValue;
        missedText.text = "Allowed misses: " + missedTargets;

        if (missedTargets < 0) // GameOver when 5 targets are missed
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        Score finalScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        gameOverInformation.text = "Congratulations, Knight, you managed to achieve " + finalScore.score + " point(s) in the tournament!";

        gameOverUI.SetActive(true);
    }
}