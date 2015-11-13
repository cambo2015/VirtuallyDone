using UnityEngine;
using System.Collections;

public class scene_change : MonoBehaviour {



	//set variables here

	//___example__
	//public type variable;


	//__Levels__
	private string scene1 = "bowling" ;
	private string scene2 = "bowling_scene2" ;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}//end update

	void OnMouseDown(){

		LoadScene ();
	}//end on click


	void LoadScene (){
		Application.LoadLevel (scene2);
	}//end load scene
}
