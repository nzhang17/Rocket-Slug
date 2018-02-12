using UnityEngine;

public class playerFuel : MonoBehaviour 
{
	public const int maxFuel = 100;
	public int currentFuel = maxFuel;

	public void TakeDamage(int amount)
	{
		currentFuel -= amount;
		if (currentFuel <= 0)
		{
			currentFuel = 0;
		}
	}
}