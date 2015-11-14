using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour 
{

	public Rigidbody Ball;




	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Ball")) 
		{
			Destroy (Ball);
		}
	}
}
