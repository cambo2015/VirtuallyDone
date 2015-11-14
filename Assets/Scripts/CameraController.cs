/*ßusing UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float speed = 10;


	private Vector3 offset;

	void Start ()
	{


	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movment = new Vector3 (moveHorizontal, 0.0f , moveVertical);
		
		//player.AddForce (movment* speed);
	
	}

		void LateUpdate ()
	{
		transform.position = player.transform.position;
		 
	}
}
*/