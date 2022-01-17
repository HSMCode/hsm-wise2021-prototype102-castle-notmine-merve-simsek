using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float speed = 4f; 
    private Vector3 StartPosition;
    public float timer;

    void Start()
    {
        StartPosition = transform.position;
    }
// Update is called once per frame

    void Update()
    {
        transform. Translate( translation: Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -21.49f)
        {
            transform.position = StartPosition;
        }
        
        timer += Time.deltaTime;

        if (timer > 25f)
        {
            speed = 6f;
        }
        
        if (timer > 50f)
        {
            speed = 10f;
        }
    }
}
