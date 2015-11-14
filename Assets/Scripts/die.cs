using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class die : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		
		if (other.gameObject.CompareTag ("Baddie")) 
		{
			
			
			Destroy(other.gameObject, 2);
					}
	}
			
}

