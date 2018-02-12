﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start (){

		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
	
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal,moveVertical,0.0f);
		rb.velocity = movement * speed;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Fuel"))
		{
			other.gameObject.SetActive (false);
		}
	}
}
