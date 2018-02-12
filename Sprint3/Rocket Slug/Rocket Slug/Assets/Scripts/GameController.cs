using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
    public static int SEVEN = 7;

    void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}

    // Creates waves of an object
	IEnumerator SpawnWaves ()
	{    
		yield return new WaitForSeconds (startWait);

		//causes a continuous amount of hazards coming to the player
		while (true) 
		{
			for (int i = 0; i < hazardCount; i++)
			{   
				// Spawning using a random range, range Variables set through unity UI
				Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), 
													 Random.Range(spawnValues.y,spawnValues.y + SEVEN), 
					                                 spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
                
				// Creates the object as a copy of the original "hazard"
				Instantiate (hazard, spawnPosition, spawnRotation);
                
				// all "wait" variables used to control spawn rate
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
