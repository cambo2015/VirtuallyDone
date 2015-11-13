using UnityEngine;
using System.Collections;

public class tester : MonoBehaviour
{
	void Start(){
		iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("zigzag"), "time", 30));
	}

}