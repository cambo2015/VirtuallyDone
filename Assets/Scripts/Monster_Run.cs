﻿using UnityEngine;
using System.Collections;

public class Monster_Run : MonoBehaviour {



	Animator anim;
	// Use this for initialization
	void Start () {

		anim = GetComponent <Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		float run = Input.GetKey("a");
		anim.SetFloat ("ToadRun", run);

		
	
	}
}
