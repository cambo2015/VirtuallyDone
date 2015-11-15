using UnityEngine;
using System.Collections;

public class start_moving : MonoBehaviour {
	Animator anim;//state animator variable


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> (); //set animation variable
		//anim.SetBool ("run",true);
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("move_monster"), "time", 20,"orienttopath",true,"loop","pingpong","easeType","linear","axis","y"));


	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("run", true);//run variable
	}
}
