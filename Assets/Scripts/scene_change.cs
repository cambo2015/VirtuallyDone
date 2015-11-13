using UnityEngine;
using System.Collections;

public class scene_change : MonoBehaviour {



	//set variables here

	//___example__
	//public type variable;






	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}//end update

	void OnMouseDown(){

		LoadScene()
	}//end on click


	void LoadScene (){
		Application.LoadLevel ("bowling_scene2");
	}//end load scene
}
