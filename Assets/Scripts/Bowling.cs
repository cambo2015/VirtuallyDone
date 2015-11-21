using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bowling : MonoBehaviour 
{


	//__Variables__(music)
	private AudioSource sound_Ball_roll;
	private AudioSource knockedOver;
	 





	public float speed;   // this is to set the speed 
	public int maxBalls;
	public Rigidbody Ball;


	private GameObject[] respawns;

	

	void bowl ()
	{

		Rigidbody BallClone = (Rigidbody)Instantiate (Ball, transform.position, transform.rotation);
		BallClone.velocity = transform.forward * speed;
		BallClone.GetComponent <Rigidbody> ().AddForce (Vector3.down * Random.Range(1,12) * 50 * 20);

			}


	void sfx(bool coolBool,bool baddieHit){
		AudioSource[] aSources = GetComponents <AudioSource>();//fix get array out of range[??]
		sound_Ball_roll = aSources[0];
		//knockedOver = aSources [1];
		Debug.Log ("length = " + aSources.Length);

		if(coolBool == true){
			sound_Ball_roll.Play();

			Debug.Log ("play sfx");
		}

		if( coolBool == false) {
			sound_Ball_roll.Stop();

			Debug.Log("stopped sfx");
		}

		if(baddieHit == true){
			//knockedOver.Play();
			Debug.Log ("knocked over played");

		}
		if(baddieHit == false){
			//knockedOver.Stop();

		}
	}




	// Update is called once per frame
	void Update () 

	{



		if (Input.GetButtonDown("Fire1"))
		{


			respawns = GameObject.FindGameObjectsWithTag("Ball");


			
			if (respawns.Length < maxBalls) {
				bowl ();
				sfx (true,false);



			}
		}

	}
	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.CompareTag ("Baddie")) 
		{

			
			Destroy(other.gameObject, 2);

			sfx (false,true);

			//SetCountText ();
		}
	}

	

}
