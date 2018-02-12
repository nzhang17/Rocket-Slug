/*Citation
  Author: Brackeys
  URL: https://www.youtube.com/watch?annotation_id=annotation_3951638185&feature=iv&src_vid=g_Ff1SPhidg&v=5CW1yGsVg4k
  */
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour 
{
	
	//Create an array to hold all the questions
	public Question[] questions;

	//Create a list for the unswered Questions
	private static List<Question> unansweredQuestions; 

	//Create a Question variable to store the current question
	public static Question CURRENTQUESTION;
    public static float TIMELEFT = 400;
    public static float ONE = 1;
    public static bool CHECK = true;
    public static float THREEHUNDRED = 400;

    //Continue button object
    public Button contButton;
    public Button False;
    
	[SerializeField]
	private Text factText;

	[SerializeField]
	private Text trueAnswerText;

	[SerializeField]
	private Text falseAnserText;

	[SerializeField]
	private Animator animator;

    void Start()
	{
        //pauses game in background
        Time.timeScale = 0.0f;

        //hides continue button
        contButton.gameObject.SetActive(false);
        if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
			unansweredQuestions = questions.ToList<Question> ();
		}

		//Call the function to set the current question
		setCurrentQuestion();

		/*Testing
		Debug.Log (currentQuestion.fact + " is " + currentQuestion.isTrue);
		*/
	}

	//Create a function 
	void setCurrentQuestion(){
		int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
		CURRENTQUESTION = unansweredQuestions [randomQuestionIndex];
		factText.text = CURRENTQUESTION.fact;

		//remove answered current question to make sure we don't answer the same question twice
		unansweredQuestions.RemoveAt(randomQuestionIndex);

		//check the answer of the question to display "correct" or "wrong"
		if (CURRENTQUESTION.isTrue) {
			trueAnswerText.text = "CORRECT!";
			falseAnserText.text = "WRONG!";
		} else {
			trueAnswerText.text = "WRONG!";
			falseAnserText.text = "CORRECT!";
		}
	
    
}
    void Update()
    {   
		//Checks if Continue has been triggered
        if (contButton.IsActive() != CHECK)
        {   
			//Keeping time ~7 Seconds. Update is done once every 30 frames
            TIMELEFT -= ONE;
            if (TIMELEFT < 0)
            {
                //Set timeLeft back, set the texts for the questions and activate continue
                TIMELEFT = THREEHUNDRED;
                trueAnswerText.text = "Too late!";
                falseAnserText.text = "Too late!";
                contButton.gameObject.SetActive(true);
            }
        }
    }
    
    //call function when the TRUE button is clicked
    public void userSelectTrue(){
        animator.SetTrigger("True");

        //Makes sure time has not been up if has, then user cant go into this function
        if (contButton.IsActive() != CHECK)
        {
            TIMELEFT = THREEHUNDRED;

            if (CURRENTQUESTION.isTrue)
            {
                //player gets fuel increased
                playerFuel.INCREASE = true;
                Debug.Log("CORRECT");
            }
            else
            {
                Debug.Log("WRONG");
            }
            contButton.gameObject.SetActive(true);
        }
    }

    //call function when the FALSE button is clicked
    public void userSelectFalse()
    {
        animator.SetTrigger("False");

        //Makes sure time has not been up if has, then user cant go into this function
        if (contButton.IsActive() != CHECK)
        {
            TIMELEFT = THREEHUNDRED;
            if (!CURRENTQUESTION.isTrue)
            {
                //player gets fuel increased
                playerFuel.INCREASE = true;
                Debug.Log("CORRECT");
            }
            else
            {
                Debug.Log("WRONG");
            }
            contButton.gameObject.SetActive(true);
        }
    }
}
