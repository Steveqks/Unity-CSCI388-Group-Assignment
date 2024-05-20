using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRaycast : MonoBehaviour
{
    [SerializeField]
    private GameObject RaycastLeft;
    [SerializeField]
    private GameObject directHandsLeft;
    [SerializeField]
    private GameObject directHandsRight;
    [SerializeField]
    private GameObject RaycastRight;

    [SerializeField]
    [Tooltip("Check left hand Raycast")]
    private bool bLeftChecktoggle = false;

    [SerializeField]
    [Tooltip("Check right hand Raycast")]
    private bool bRightChecktoggle = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(bLeftChecktoggle)
        {
            ToggleLeftRaycastOff();
        }
       else
        {
            ToggleLeftRaycastOn();
        }

       if (bRightChecktoggle)
        {
            ToggleRightRaycastOff();
        }
       else
        {
            ToggleRightRaycastOn();
        }
    }

    public void leftToggle()
    {
        if(bLeftChecktoggle)
        {
            bLeftChecktoggle = false;
        }
        else
        {
            bLeftChecktoggle = true;
        }
    }
    public void rightToggle()
    {
        if (bRightChecktoggle)
        {
            bRightChecktoggle = false;
        }
        else
        {
            bRightChecktoggle = true;
        }
    }

    public void ToggleLeftRaycastOn()
    {
        RaycastLeft.SetActive(true);
        directHandsLeft.SetActive(false);
    }
    public void ToggleRightRaycastOn()
    {
        RaycastRight.SetActive(true);
        directHandsRight.SetActive(false);
    }
    public void ToggleLeftRaycastOff()
    {
        RaycastLeft.SetActive(false);
        directHandsLeft.SetActive(true);
    }
    public void ToggleRightRaycastOff()
    {
        RaycastRight.SetActive(false);
        directHandsRight.SetActive(true);
    }
}
