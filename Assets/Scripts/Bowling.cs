using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bowling : MonoBehaviour 
{

	public float speed;   // this is to set the speed 

	public Rigidbody Ball;

	
	private int count;


	void bowl ()
	{

		Rigidbody BallClone = (Rigidbody)Instantiate (Ball, transform.position, transform.rotation);
		BallClone.velocity = transform.forward * speed;
	}
	// Update is called once per frame
	void Update () 

	{
		if (Input.GetKeyDown("space")) 
		{
			bowl ();
		}

	}
	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.CompareTag ("Baddie")) 
		{
		
			Destroy(other.gameObject, 2);
			//count = count + 1;
			//SetCountText ();
		}
	}
	
	/*void SetCountText ()
		
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 15) 
		{
			winText.text = "You Win!!!"; 
		}
	}*/
}
