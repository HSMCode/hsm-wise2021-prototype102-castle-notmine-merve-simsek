using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitParticles : MonoBehaviour
{

    // Emit particles when hitting a target
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) {
            gameObject.GetComponent<ParticleSystem>().Emit(7);
        }
    }
}
