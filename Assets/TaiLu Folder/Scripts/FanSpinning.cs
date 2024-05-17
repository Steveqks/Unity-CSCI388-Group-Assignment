using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Video;

public class FanSpinning : MonoBehaviour
{
    [SerializeField]
    private bool spinning = false;
    [SerializeField]
    [Tooltip("To Slowly increase and decrease the speed of the fan when it start and stop")]
    private float ControlSpeed = 20f;
    [SerializeField]
    private float totalSpeed = 0f;
    [SerializeField]
    private float AngleX = 0f;
    [SerializeField]
    private float AngleZ = 0f;
    [SerializeField]
    private bool test = false;

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
                if (ControlSpeed == 0f)
                {
                    StopCoroutine(SpinToStop());
                }
            }
        }
    }
    IEnumerator Spin()
    {
        ControlSpeed += 0.05f * Time.deltaTime;
        if (ControlSpeed > 1.0f)
        {
            ControlSpeed = 1.0f;
        }
        totalSpeed += ControlSpeed * Time.deltaTime;
        if (totalSpeed > 5.0f)
        {
            totalSpeed = 5.0f;
        }
        transform.Rotate(AngleX, totalSpeed, AngleZ);
        yield return new WaitForSeconds(1);
    }

    IEnumerator SpinToStop()
    {
        ControlSpeed -= 0.05f * Time.deltaTime;
        if (ControlSpeed < -0f)
        {
            ControlSpeed = 0.0f;
        }
        totalSpeed -= ControlSpeed * Time.deltaTime;
        if (totalSpeed < 0.0f)
        {
            totalSpeed = 0;
            spinning = false;
        }
        transform.Rotate(AngleX, totalSpeed, AngleZ);
        yield return new WaitForSeconds(1f);
    }

    public void startSpin()
    {

    }
    public void stopSpin()
    {

    }

    public void ToggleStartStop()
    {
        spinning = !spinning;
    }
}
