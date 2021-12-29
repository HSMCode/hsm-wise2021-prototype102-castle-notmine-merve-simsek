using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
 
    private float timer;
    public int score;
 
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }
 
    public virtual void Update()
    {
        timer += Time.deltaTime;
 
        if (timer > 1f)
        {
            AddScore(1);
            timer = 0;
        }
    }
 
    public void AddScore(int addedValue)
    {
        score += addedValue;
        scoreText.text = "Score: " + score;
    }
}