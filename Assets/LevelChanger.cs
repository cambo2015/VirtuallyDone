﻿using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {

	public string NextLevel;

	private GameObject respawnPrefab;
	private GameObject[] respawns;



	void checkBaddies() {
		respawns = GameObject.FindGameObjectsWithTag("Baddies");
		Debug.Log ("number of badies" + respawns.Length);
		if (respawns.Length == 0) {

			Application.LoadLevel(NextLevel);
		}

	}
}