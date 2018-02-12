using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerFuel : MonoBehaviour 
{
    //static var so that it can be used across all scripts
    //used to determine if player got math question correct
    public static bool INCREASE = false;

	//maxFuel could be changed from inspector tab
	public const float maxFuel = 55;

	//burnRate can also be chagned from inspector tab
	//determines how quickly fuel is burned
	public float burnRate = 0.02f;

	//used to hold current fuel level
	public float currentFuel = maxFuel;

	//bar object that represents current amount of fuel
	public RectTransform fuelBar;

    //takes away a specific amount of fuel
    public void TakeDamage(float amount)
	{   
		currentFuel -= amount;

		//makes sure fuel amount is not negative
		if (currentFuel <= 0)
		{
            SceneManager.LoadScene("DeathScreen", LoadSceneMode.Single);
			currentFuel = 0;    
		}

		//used to resize fuel bar to reflect current fuel amount
		fuelBar.sizeDelta = new Vector2 (fuelBar.sizeDelta.x, currentFuel);
	}

	//increases fuel amount by a specific amount
	public void IncreaseFuel()
	{
        if (INCREASE)
        {
            currentFuel += 10f;

            //makes sure player does not have more than max fuel level
            if (currentFuel >= maxFuel)
            {
                currentFuel = maxFuel;
            }
            fuelBar.sizeDelta = new Vector2(fuelBar.sizeDelta.x, currentFuel);

            //set back to false so that fuel is not being constantly added in update()
            INCREASE = false;
        }
    }

	//takes away fuel amount specified by burn rate var
	public void BurnFuel () 
	{
		TakeDamage (burnRate);
	}

	//calls BurnFuel every fixed frame to create burn rate
	void FixedUpdate() 
	{
		//constantly burning up fuel
		BurnFuel();

        //constantly checks to see if player got question correct
        //work around to player object not being in additive math scene
        if (playerFuel.INCREASE)
        {
            IncreaseFuel();
        }
    }
}