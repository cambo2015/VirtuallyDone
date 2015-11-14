using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		
		if (other.gameObject.CompareTag ("Baddie")) 
		{
			
			Destroy(other.gameObject, 4);
			//count = count + 1;
			//SetCountText ();
		}
	}
}
