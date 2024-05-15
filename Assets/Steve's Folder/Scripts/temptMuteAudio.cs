using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temptDisableAudio : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component to disable

    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to temporarily disable the AudioSource
        StartCoroutine(DisableAndEnableAudioSource());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DisableAndEnableAudioSource()
    {
        // Check if the audioSource reference is set
        if (audioSource != null)
        {
            // AudioSource mute
            audioSource.mute = true;

            // Wait for some seconds
            yield return new WaitForSeconds(3f);

            // AudioSource unmute
            audioSource.mute = false;
        }
        else
        {
            Debug.LogWarning("No AudioSource assigned to disable.");
        }
    }
}
