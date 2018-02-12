using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resumeScene : MonoBehaviour {

	// Unpauses gameplay and destroys math scene
	public void resScene () {
        Time.timeScale = 1.0f;
        SceneManager.UnloadSceneAsync("MathProblem");
        //resumes gameplay music
        sound.PLAY = true;
    }
}
