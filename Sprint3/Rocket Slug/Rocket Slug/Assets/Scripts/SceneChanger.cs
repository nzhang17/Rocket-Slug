using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour {

	// Use this for initialization
	void Start () {
      //  LoadStage();
	}

	//Loads main game
    public void LoadStage()
    {     
        SceneManager.LoadScene("SkyBG1", LoadSceneMode.Single);   
    }

    //Exits Application
    public void ExitGame()
    {
        Application.Quit();
    }
}
