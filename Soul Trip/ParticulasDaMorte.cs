using UnityEngine;
using System.Collections;

public class ParticulasDaMorte : MonoBehaviour {

	public GameObject particula;

	// Use this for initialization
	void Start () {
	
		particula.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {

		MyAI AI=(MyAI)GetComponent("MyAI");
		if(AI){
			if(AI.IsDead){
				particula.SetActive(true);
			}
		}

	
	}
}
