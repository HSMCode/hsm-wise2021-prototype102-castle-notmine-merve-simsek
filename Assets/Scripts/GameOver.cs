using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public TextMeshProUGUI gameOverInformation;
    public float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
 
 
 void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Lance"))
            {
                Time.timeScale = 0;
                gameOverUI.SetActive(true);
                gameOverInformation.text = "Congratulations, Knight, you managed to achieve " + (int)timer +
                                           " point(s) in the tournament!";
            }
        }
}
