using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleReticle : MonoBehaviour
{

    [SerializeField]
    private GameObject gReticle;

    [SerializeField]
    private bool bScaleUp = true;

    [SerializeField]
    private bool bScaleDown = false;
    [SerializeField]
    [Tooltip("Scale speed")]
    private float scaleValue = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        gReticle = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(gReticle.transform.localScale.x > 0.8f)
        {
            bScaleUp = false;
            bScaleDown = true;
        }
        if (gReticle.transform.localScale.x < 0.3f)
        {
            bScaleDown = false;
            bScaleUp = true;
        }

        if(bScaleUp)
        {
            gReticle.transform.localScale += new Vector3(scaleValue * Time.deltaTime, 0, scaleValue * Time.deltaTime);
        }
        if(bScaleDown)
        {
            gReticle.transform.localScale += new Vector3(-scaleValue * Time.deltaTime, 0, -scaleValue * Time.deltaTime);
        }


    }
}
