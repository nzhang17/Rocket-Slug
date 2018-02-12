using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class playerFuel : MonoBehaviour 
{
	public const int maxFuel = 100;
	public int currentFuel = maxFuel;
	public RectTransform fuelBar;

	public void TakeDamage(int amount)
	{
		currentFuel -= amount;
		if (currentFuel <= 0)
		{
			currentFuel = 0;
		}
		fuelBar.sizeDelta = new Vector2 (fuelBar.sizeDelta.x, currentFuel);
	}

	public void IncreaseFuel(int amount)
	{
		if (currentFuel <= 100) 
		{
			currentFuel += amount;
		}
	}
}