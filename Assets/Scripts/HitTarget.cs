using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTarget : MonoBehaviour
{
    public Score score;

    // Update is called once per frame
    void Update()
    {
        // Move Target from right to left
        transform.Translate(Vector3.left * Time.deltaTime * 4);
    }

    // Destroy Object once it collides with another object. If it collides with the lance: Add 3 Points to the current score
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lance")
        {
            score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
            score.AddScore(3);
        }

        Destroy(gameObject, 0.1f);

    }

    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Border"))
            {
                score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
                score.AllowedMisses(1);
            }
            Destroy(gameObject, 0.1f);
        }
}

