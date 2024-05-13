using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    bool spinning = false;
    float speed;

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
        speed = 0f;
        while (speed <= 300f)
        {
            speed += speed + 30f;
            transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        }
    }

    public void SpinToStop()
    {
        while (speed >= 300f && speed != 0f)
        {
            speed += speed - 30f;
            transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        }
    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
