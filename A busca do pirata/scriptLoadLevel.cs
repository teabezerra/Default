﻿using UnityEngine;
using System.Collections;

public class scriptLoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadLevel()
    {

        Application.LoadLevel("Level1");

    }

}
