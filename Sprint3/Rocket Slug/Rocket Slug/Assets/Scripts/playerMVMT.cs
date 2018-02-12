using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMVMT : MonoBehaviour 
{
    //player z and y position
    public float playerZ = 1.02f;
    public float playerY = -3;

    //left and right player bounds
    public float leftBound = -2.45f;
    public float rightBound = 2.4f;

    //holds value position should change by
    public float fingerDelta;

    // 1/5 of the screen
    float fifthOfScreen = Screen.width / 5;

    /*private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }*/
	
    // Update is called once per frame
    void Update () 
	{
        //player should only use one finger
		if (Input.touchCount == 1) {
			
            //touch object holds info of fingerp position
			Touch touch = Input.GetTouch (0);

            //dividing  the change in position by a fifth of the screen
            //gives an ideal amount of movement
            fingerDelta = touch.deltaPosition.x / fifthOfScreen;

            //makes sure player does not go out of view
            float x = Mathf.Clamp(transform.position.x + fingerDelta, leftBound, rightBound);

            //changes position of player
            transform.position = new Vector3 (x, playerY, playerZ);
		}
	}
}
