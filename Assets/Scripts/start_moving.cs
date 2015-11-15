using UnityEngine;
using System.Collections;

public class start_moving : MonoBehaviour {
	Animator anim;//state animator variable
	private int runspeed = 40;


	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> (); //set animation variable
		//anim.SetBool ("run",true);
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("move_monster"), "time", runspeed ,"orienttopath",true,"loop","pingpong","easeType","linear","axis","y"));


	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("run", true);//run variable
	}
}
