using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    bool spinning = false;
    float MaxSpeed;
    float MinSpeed = 0f;
    float AngleX = 0f; 
    float AngleZ = 0f;
    bool test = false;

    // Start is called before the first frame update
    void Start()
    {
        spinning = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (spinning == true)
        {
            StartCoroutine(Spin());
            test = true; 
        }
        else if (spinning == false)
        {
            if (test == true)
            {
                StartCoroutine(SpinToStop());
            }
        }
    }
    IEnumerator Spin()
    {
        for (MaxSpeed = 0f; MaxSpeed < 20f; MaxSpeed+= 0.5f)
        {
            transform.Rotate(AngleX, MaxSpeed * Time.deltaTime, AngleZ, Space.Self);
            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator SpinToStop()
    {
        for (MinSpeed = MaxSpeed; MinSpeed >= 0f; MinSpeed-= 0.5f)
        {
            transform.Rotate(AngleX, MinSpeed * Time.deltaTime, AngleZ, Space.Self);
            yield return new WaitForSeconds(.1f);
        }
    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
