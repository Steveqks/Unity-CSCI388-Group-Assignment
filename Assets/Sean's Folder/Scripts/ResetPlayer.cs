using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Set this to player to prevent eternal dropping below -5.5f")]
    private GameObject gPlayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If player is below -5.5f just reset to 0 0 0 unless start point is somewhere else.
        if (gPlayer.transform.position.y < -5.5f)
        {
            gPlayer.transform.position = new Vector3(0, 0, 0);
        }
    }
}
