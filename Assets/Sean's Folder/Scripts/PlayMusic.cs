using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayMusic : MonoBehaviour
{

    [SerializeField]
    [Tooltip("Audiosource to play your music here")]
    private AudioSource MusicSource;

    [SerializeField]
    [Tooltip("Other Disc coming in on trigger")]
    private GameObject discObject;

    [SerializeField]
    [Tooltip("Music List")]
    private List<AudioClip> musicList;

    [SerializeField]
    private bool bMusicCheck = false;

    [SerializeField]
    [Tooltip("Rotation speed of object")]
    private float rotateSpeed = 2.0f;

    [SerializeField]
    GameObject gHook;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MusicSource.clip == null)
        {
            MusicSource.Stop();
        }
        if(bMusicCheck && discObject != null)
        {
           
            gHook.transform.Rotate(0, rotateSpeed * Time.deltaTime, 0,Space.World);
            Debug.Log(discObject + "Rotating");
        }
    }

    public void playMusic()
    {
        if (MusicSource.clip != null)
        {
            bMusicCheck = true;
            MusicSource.Play();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("RedDisc"))
        {
            discObject = other.gameObject;
            MusicSource.clip = musicList[0];
            
        }
        if (other.gameObject.name.Equals("BlueDisc"))
        {
            discObject = other.gameObject;
            MusicSource.clip = musicList[1];
        }
        if (other.gameObject.name.Equals("PurpleDisc"))
        {
            discObject = other.gameObject;
            MusicSource.clip = musicList[2];
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("RedDisc"))
        {
            discObject = null;
            MusicSource.clip = null;
            bMusicCheck = false;
        }
        if (other.gameObject.name.Equals("BlueDisc"))
        {
            discObject = null;
            MusicSource.clip = null;
            bMusicCheck = false;
        }
        if (other.gameObject.name.Equals("PurpleDisc"))
        {
            discObject = null;
            MusicSource.clip = null;
            bMusicCheck = false;
        }
    }
   
}
