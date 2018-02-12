using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMVMT : MonoBehaviour {	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			Touch touch = Input.GetTouch (0);
			float x = -7.5f + 15 * touch.position.x / Screen.width;

			transform.position = new Vector3 (x, -3, 0);
		}
		
	}
}
