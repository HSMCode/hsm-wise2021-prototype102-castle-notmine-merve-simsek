using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Up and Down Movement for the Horse
        float y = Mathf.PingPong(Time.time, 0.2f);

        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
