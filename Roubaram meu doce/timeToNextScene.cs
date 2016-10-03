using UnityEngine;
using System.Collections;

public class timeToNextScene : MonoBehaviour {

	public string levelToLoad;
	private float time = 5f, counter = 0;
	public float totalDeFrames = 1, framesPorSegundo = 1;


	// Use this for initialization
	void Start () {
		time = totalDeFrames/framesPorSegundo;
	}


	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		if(counter>=time)
			next();
	}


	void next(){
		Application.LoadLevel(this.levelToLoad);
	}


}
