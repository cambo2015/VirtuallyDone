using UnityEngine;
using System.Collections;

public class change_ball_material : MonoBehaviour {


	private Object[] balls;


	// Use this for initialization
	void Start () {

		Destroy(gameObject, 8);
		balls = Resources.LoadAll ("bowling_balls" );//returns an array
		int ball_count = balls.Length;
		Debug.Log (ball_count);




		gameObject.GetComponent <Renderer> ().material = balls[Random.Range(0, ball_count)] as Material;
		gameObject.GetComponent <Rigidbody> ().AddForce (Vector3.down * 10);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
