﻿using UnityEngine;
using System.Collections;

public class creditos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void loadlevel()
    {
        Application.LoadLevel("creditos");
    }

    public void loadjuego()
    {
        Application.LoadLevel("bomba");
    }
}
