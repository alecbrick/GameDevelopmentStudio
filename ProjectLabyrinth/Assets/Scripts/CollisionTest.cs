﻿using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {
	
	void OnCollisionEnter (Collision other)
	{
		Debug.Log ("Object Entered the Collision");
	}
	
	/*void OnCollisionStay (Collision other)
	{
		Debug.Log ("Object Inside the trigger");
	}
	
	void OnCollisionExit (Collision other)
	{
		Debug.Log ("Object has Exited the trigger");
	}*/
}
