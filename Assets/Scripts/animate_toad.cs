using UnityEngine;
using System.Collections;

public class animate_toad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Animation>().Play ("Toad_Idle");
	}
}
