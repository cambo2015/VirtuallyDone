using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {

	public string NextLevel;

	private GameObject respawnPrefab;
	private GameObject[] respawns;

	void Start (){

		InvokeRepeating("checkBaddies", 3, 3);
	}

	void checkBaddies() {
		respawns = GameObject.FindGameObjectsWithTag("Baddie");
		Debug.Log(respawns.Length);

		if (respawns.Length == 0) {

			Application.LoadLevel(NextLevel);
		}

	}
}
