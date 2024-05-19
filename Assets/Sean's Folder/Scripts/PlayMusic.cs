using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private float rotateSpeed = 2.0f;


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
           
            this.transform.Rotate(rotateSpeed * Time.deltaTime,0,0);
            Debug.Log(discObject + "Rotating");
        }
    }

    public void playMusic()
    {
        if (MusicSource.clip != null)
        {
            MusicSource.Play();
            bMusicCheck = true;
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
    }
}
