using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

    [SerializeField]
    script_BackgroundSoundManger BackgroundSoundManger;
    [SerializeField]
    AudioClip Game_BackgroundMusic;

    // Use this for initialization
    void Start () {

        BackgroundSoundManger.playBackgroundsound(Game_BackgroundMusic);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
