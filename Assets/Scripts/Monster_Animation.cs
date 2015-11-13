using UnityEngine;
using System.Collections;

public class Monster_Animation : MonoBehaviour {


	//__Variables___(Animation)
	Animator anim;

	//__Variables___(GameObj);
	GameObject greenMonster;





	// Use this for initialization
	void Start () {
	
		anim = GetComponent <Animator> ();
	
	}

	// Update is called once per frame
	void Update () {

		//if space is pressed play animation in the AC

		//Character Animation
			
		if(Input.GetKey("space")){//if press space
			float moveacross = 1;

			greenMonster.transform.position += moveacross;
			anim.SetBool ("run",true);//find the bool set in the animation tab in unity and set it to true

		}
		//bool run = Input.GetKey("space");
		//anim.SetBool ("monster2Run", run);
	}
}
