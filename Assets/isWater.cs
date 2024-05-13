using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterBool : MonoBehaviour
{
    public GameObject objectToRotate;
    public GameObject waterParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the objectToRotate reference is not null
        if (objectToRotate != null)
        {
            // Get the rotation of the object in Euler angles
            Vector3 rotation = objectToRotate.transform.rotation.eulerAngles;

            // Check if the X-axis rotation is greater than 45 degrees and less than 180 degrees
            if (rotation.x > 30f && rotation.x < 180f)
            {
                //Debug.Log("X axis rotation is between 45 and 180 deg");
                waterParticle.SetActive(true);
            }
            else
            {
                waterParticle.SetActive(false);
            }
        }
        else
        {
            Debug.LogWarning("Object to rotate in the Inspector not assigned");
        }
    }
}
