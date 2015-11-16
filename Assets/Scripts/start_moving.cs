using UnityEngine;
using System.Collections;

public class start_moving : MonoBehaviour {

	/*[Notes] I tried to attach the itween path to other MOnsters but they bunched up. I atached this script to only 1 monster and I also only
	attached the itween path to only 1 monster...see Swamp_Monster1 components in the unity editor - Cambo*/



	//__Variables__(Monsters)
	public GameObject SwampMonster1;
	public GameObject SwampMonster2;
	/*public GameObject SwampMonster3;
	public GameObject SwampMonster4;
	public GameObject SwampMonster5;
	public GameObject SwampMonster6;
	public GameObject SwampMonster7;
	public GameObject SwampMonster8;
	public GameObject SwampMonster9;
	public GameObject GiantToad;*/






	//__Variables iTween
	private int runspeed = 40;




	// Use this for initialization
	void Start () {
		//__Variables__(Animation)
		Animator anim = GetComponent <Animator>();//state animator variable



		//__Variables__(arrays)
		string[] monsterNumbers = {"1","2","3","4","5","6","7","8","9"};
		GameObject[] SwampMonsters = {
			SwampMonster1,
			SwampMonster2,
			/*SwampMonster3,
			SwampMonster4,
			SwampMonster5,
			SwampMonster6,
			SwampMonster7,
			SwampMonster8,
			SwampMonster9*/
		};//the commented parts are not made yet;

		//impliments itween for all 9 Swamp_Monsters with the same runspeed;
		for(int i =0; i< SwampMonsters.Length; i ++){
			iTween.MoveTo(SwampMonsters[i], iTween.Hash("path", iTweenPath.GetPath("chinaMonster"+ monsterNumbers[i]), "time", runspeed ,"orienttopath",true,"loop","pingpong","easeType","linear","axis","y"));
			Debug.Log (SwampMonsters[i]);
			//anim = SwampMonsters[i].GetComponent <Animator> (); //set animation variable
		}

		//Animate Running for Swamp_monsters
		SwampMonster1.GetComponent <Animator>().SetBool ("run",true);//"run" is set in the AnimationController, true is too.
		SwampMonster2.GetComponent <Animator> ().SetBool ("run",true);


		//anim.SetBool ("run",true);

		//iTween.MoveTo(SwampMonster2, iTween.Hash("path", iTweenPath.GetPath("chinaMonster2"), "time", runspeed ,"loop","pingpong"));

	}
	
	// Update is called once per frame
	void Update () {

		//this runs the running animation every frame:D
		//anim.SetBool ("run", true);//run variable
	}
}
