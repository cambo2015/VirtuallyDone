using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bowling : MonoBehaviour 
{

	public float speed;   // this is to set the speed 
	public int maxBalls;
	public Rigidbody Ball;


	private GameObject[] respawns;

	
	private int count;


	void bowl ()
	{

		Rigidbody BallClone = (Rigidbody)Instantiate (Ball, transform.position, transform.rotation);

		BallClone.velocity = transform.forward * speed;
		BallClone.GetComponent <Rigidbody> ().AddForce (Vector3.down * Random.Range(1,12) * 50 * 20);
			}
	// Update is called once per frame
	void Update () 

	{
		if (Input.GetButtonDown("Fire1"))
		{
			respawns = GameObject.FindGameObjectsWithTag("Ball");
			
			if (respawns.Length < maxBalls) {
			bowl ();
			}
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
