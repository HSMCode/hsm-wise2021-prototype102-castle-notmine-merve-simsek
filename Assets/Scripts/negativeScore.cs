using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class negativeScore : MonoBehaviour
{
    public TMP_Text missedText;
    public GameObject gameOverUI;
    public TextMeshProUGUI gameOverInformation;
    public int missedTargets;
    public float timer;

    private void Start()
    {
        missedTargets = 5;
        gameOverUI.SetActive(false); 
    }

    private void Update()
    {
        UIUpdate();
        timer += Time.deltaTime;
        
        if (missedTargets < 0) // GameOver when 5 targets are missed
        {
            GameOver();
        }
    }

   public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            missedTargets --;

        }
        Destroy(other.gameObject, 0.1f);
    }

    private void UIUpdate()
    {
        missedText.text = "Allowed misses: " + missedTargets;
    }

    public void GameOver()
    { 
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
        gameOverInformation.text = "Congratulations, Knight, you managed to achieve " + (int)timer +
                                   " point(s) in the tournament!";
        
    }
}