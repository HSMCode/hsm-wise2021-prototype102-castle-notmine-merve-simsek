using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private float timer;
    public int score;
    //public int finalScore;

    void Start()
    {
        score = 0;
    }
    void Update()
    {
        UIUpdate();
        //finalScore = score;
        // add 1 point every second
        timer += Time.deltaTime;

        if (timer > 1f)
        {
            score++;
            timer = 0;
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Debug.Log("Sound");
        }

        Destroy(collision.gameObject, 0.1f);
    }

    private void UIUpdate()
    {
        scoreText.text = "Score: " + score;
    }
}