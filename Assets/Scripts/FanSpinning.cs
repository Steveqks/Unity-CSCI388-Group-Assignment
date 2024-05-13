using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    bool spinning = false;
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

        }
    }
    public void Spin()
    {
        transform.Rotate(0f, 300f * Time.deltaTime, 0f, Space.Self);
    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
