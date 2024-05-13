using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    bool spinning = false;
    bool speed = false;
    float Maxspeed;

    // Start is called before the first frame update
    void Start()
    {
        spinning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spinning == true)
        {
            Spin();
        }
        else if (spinning == false)
        {
            SpinToStop();
        }
    }
    public void Spin()
    {
        float Maxspeed = 0f;
        while (speed == false)
        {
            if (Maxspeed != 300f)
            {
                Maxspeed += Maxspeed + 30f;
                transform.Rotate(0f, Maxspeed * Time.deltaTime, 0f, Space.Self);
            }
            else
            {
                speed = true;
            }
        }
    }

    public void SpinToStop()
    {
        while (speed == true)
        {
            if (Maxspeed != 0f)
            {
                Maxspeed += Maxspeed - 30f;
                transform.Rotate(0f, Maxspeed * Time.deltaTime, 0f, Space.Self);
            }
            else
            {
                speed = false;
            }
        }
    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
