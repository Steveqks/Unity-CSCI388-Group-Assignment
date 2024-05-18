using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        // Handle the collision with the object 'other'
        //Debug.Log("Particle collided with " + other.name);
        other.transform.Rotate(0, 1, 0);
    }
}
