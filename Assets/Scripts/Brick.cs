﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Hit", gameObject);
		Destroy (gameObject);
	}

}