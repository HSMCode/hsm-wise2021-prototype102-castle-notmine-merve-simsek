using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class negativeScore : MonoBehaviour
{
    public TMP_Text missedText;
    public GameObject gameOverUI;
    public TMP_Text gameOverInformation;
    
    public Score score;
    public int missedTargets;

    private void Start()
    {
        score = GetComponent<Score>();
        missedTargets = 5;
        gameOverUI.SetActive(false); 
    }

    private void Update()
    {
        UIUpdate();
    }

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            missedTargets --;

        }
        Destroy(other.gameObject, 0.1f);
        
        if (missedTargets < 0) // GameOver when 5 targets are missed
        {
            GameOver();
        }
    }

    private void UIUpdate()
    {
        missedText.text = "Allowed misses: " + missedTargets;
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
        gameOverInformation.text = "Congratulations, Knight, you managed to achieve " + score.finalScore + " point(s) in the tournament!";
    }
}