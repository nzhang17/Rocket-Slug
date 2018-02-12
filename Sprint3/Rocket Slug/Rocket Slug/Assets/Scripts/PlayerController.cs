using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    //controls movement speed
	public float speed;

    //req. object for desired physics
	private Rigidbody rb;

    void Start ()
	{    
		//gets attributes
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		
	    //horizontal movement
		float moveHorizontal = Input.GetAxis ("Horizontal");

        //vertical movement
		float moveVertical = Input.GetAxis ("Vertical");

        //new position vector
		Vector3 movement = new Vector3 (moveHorizontal,moveVertical,0.0f);

        //applies speed
		rb.velocity = movement * speed;
	}
}
