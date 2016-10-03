using UnityEngine;
using System.Collections;

public class script_BackgroundSoundManger : MonoBehaviour {

    public static script_BackgroundSoundManger sigleton;
    AudioSource audiosource;

    void Awake()
    {
        sigleton = this;
    }

    // Use this for initialization
    void Start () {

        audiosource = GetComponent<AudioSource>();
        audiosource.mute = false;
        audiosource.loop = true;
        audiosource.playOnAwake = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void playBackgroundsound(AudioClip c)
    {

        if (audiosource.isPlaying)
            audiosource.Stop();

        audiosource.clip = c;

        audiosource.Play();

    }
    
}
