using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    bool spinning = false;
    float Maxspeed;
    float MinSpeed = 0f;

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
        }
        else if (spinning == false)
        {
            StartCoroutine(SpinToStop());
        }
    }
    IEnumerator Spin()
    {
        for (Maxspeed = 0f; Maxspeed < 15f; Maxspeed+= 0.1f)
        {
            transform.Rotate(0f, Maxspeed * Time.deltaTime, 0f, Space.Self);
            yield return new WaitForSeconds(.1f);
        }
    }

    IEnumerator SpinToStop()
    {
        for (MinSpeed = Maxspeed; MinSpeed >= 0; MinSpeed-= 0.1f)
        {
            transform.Rotate(0f, MinSpeed * Time.deltaTime, 0f, Space.Self);
            yield return new WaitForSeconds(.1f);
        }
    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
