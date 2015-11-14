using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class count : MonoBehaviour {

	public Text countText;
	public int number = 0;

	private GameObject[] baddies;


	
	// Update is called once per frame
	void Update () {
	
		baddies = GameObject.FindGameObjectsWithTag ("Baddie");
		number = baddies.Length;
		SetCountText ();

	}
	void SetCountText ()
		
	{
		countText.text = "Count: " + number.ToString ();
		
	}
}
