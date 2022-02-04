using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTargets : MonoBehaviour
{ 
    [SerializeField] public float speed;

    void Start()
    {
        speed = 4f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
