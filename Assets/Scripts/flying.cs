using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class flying : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    private bool gameStarted;
    [SerializeField] private GameObject startingPanel; // Instruction for the Game

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0; // Pause Game
        gameStarted = false;
        startingPanel.SetActive(true); // Instruction visible
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted == false && Input.GetKeyUp(KeyCode.Space)) 
        {
            gameStarted = true; 
            Time.timeScale = 1; // Starting Game
            startingPanel.SetActive(false); // hide Instructions 
        }
        
        if (gameStarted == true && Input.GetKeyDown(KeyCode.Space))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
}
