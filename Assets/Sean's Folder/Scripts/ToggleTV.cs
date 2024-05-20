using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTV : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Select TV Gameobject to play videos on")]
    private GameObject TV;

    [SerializeField]
    [Tooltip("Check if TV is on")]
    private bool btoggleTV = false;

    [SerializeField]
    [Tooltip("Check if TV is playing video")]
    private bool bPlaying = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (btoggleTV)
        {
            toggleVideoOn();
        }
        else
        {
            toggleVideoOff();
        }
    }
    public void toggleTVButton()
    {
        if (!btoggleTV)
        {
            btoggleTV = true;
        }
        else
        {
            btoggleTV = false;
        }
    }
    void toggleVideoOn()
    {
        var videoPlayer = TV.GetComponentInChildren<UnityEngine.Video.VideoPlayer>();
        if (!bPlaying)
        {
            videoPlayer.Play();
            bPlaying = true;
        }
    }
    void toggleVideoOff()
    {
        var videoPlayer = TV.GetComponentInChildren<UnityEngine.Video.VideoPlayer>();
        if (bPlaying)
        {
            videoPlayer.Stop();
            bPlaying = false;
        }

        
    }
}
