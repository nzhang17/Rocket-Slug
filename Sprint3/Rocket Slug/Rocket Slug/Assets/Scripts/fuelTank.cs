using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fuelTank : MonoBehaviour {

    //detects collision
	void OnTriggerEnter(Collider other) 
	{
        //checks if collision with player
		if (other.gameObject.CompareTag ("Player"))
		{
            //checks to make sure it's a fuel tank
            if (this.gameObject.name == "fuelTank(Clone)")
            {
                //destroys fuel tank once player hits it
                Destroy(this.gameObject);

            }
            //loads math problem scene
            SceneManager.LoadScene("MathProblem", LoadSceneMode.Additive);
            //pauses game play music
            sound.PLAY = false;
            
        }
	}
}
