﻿using UnityEngine;
using System.Collections;

public class Rotator: MonoBehaviour
{
	public float tumble;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
