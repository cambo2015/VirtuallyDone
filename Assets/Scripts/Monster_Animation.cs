﻿using UnityEngine;
using System.Collections;

public class Monster_Animation : MonoBehaviour {


	//__Variables___(Animation)
	Animator anim;


	//__Variables__(Random)
	private float random_number_of_monsters;







	private float x;
	private float y;
	private float z;


	// Use this for initialization
	void Start () {

		//Random
		random_number_of_monsters = Random.Range(1,5);



		Debug.Log (random_number_of_monsters);

		//Animation
		anim = GetComponent <Animator> ();
	}

	// Update is called once per frame
	void Update () {


		//Instianciate new monsters 
		//at random position;





		//if space is pressed play animation in the AC

			//Character Animation
			//move forward
			

		if(Input.GetKey("up")){//if press space
			anim.SetBool ("run",true);//find the bool set in the animation tab in unity and set it to true
			//CHRISTEN PUTS MOVING CODE HERE :D
		}

		if(Input.GetKey("down")){
			anim.SetBool ("run",false);
		}


		//bool run = Input.GetKey("space");
		//anim.SetBool ("monster2Run", run);
	}
}
