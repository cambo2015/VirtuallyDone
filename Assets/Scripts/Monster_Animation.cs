using UnityEngine;
using System.Collections;

public class Monster_Animation : MonoBehaviour {


	//__Variables___(Animation)
	Animator anim;








	// Use this for initialization
	void Start () {
	
		anim = GetComponent <Animator> ();
	
	}

	// Update is called once per frame
	void Update () {

		//if space is pressed play animation in the AC

			//Character Animation
			//move forward
			

		if(Input.GetKey("space")){//if press space
			anim.SetBool ("run",true);//find the bool set in the animation tab in unity and set it to true
			//CHRISTEN PUTS MOVING CODE HERE :D


		}
		//bool run = Input.GetKey("space");
		//anim.SetBool ("monster2Run", run);
	}
}
