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

    private bool bChecktoggle = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(bChecktoggle)
        {
            ToggleRaycastOff();
        }
       else
        {
            ToggleRaycastOn();
        }
    }

    public void toggle()
    {
        if(bChecktoggle)
        {
            bChecktoggle = false;
        }
        else
        {
            bChecktoggle = true;
        }
    }

    public void ToggleRaycastOn()
    {
        RaycastLeft.SetActive(true);
        RaycastRight.SetActive(true);
        directHandsLeft.SetActive(false);
        directHandsRight.SetActive(false);
    }
    public void ToggleRaycastOff()
    {
        RaycastLeft.SetActive(false);
        RaycastRight.SetActive(false);
        directHandsLeft.SetActive(true);
        directHandsRight.SetActive(true);
    }
}
