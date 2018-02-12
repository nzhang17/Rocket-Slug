using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour 
{    
    void OnTriggerEnter(Collider other) 
	{   
		//If we hit the player
		if (other.gameObject.CompareTag ("Player"))
		{   
			// Get the player fuel component and call the take damage function to apply damage
			var hit = other.gameObject;
			var fuel = hit.GetComponent<playerFuel>();
			fuel.TakeDamage (5);

            // Deleting the object on contact -> no exponential growth
            if (this.gameObject.name == ("asteroid(Clone)"))
            {
                Destroy(this.gameObject);
            }
		}

	}
}
