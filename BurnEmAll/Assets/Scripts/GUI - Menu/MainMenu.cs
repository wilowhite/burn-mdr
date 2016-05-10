using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public static bool DisableContinue = true;
	public Transform continuelife;
	public static bool checkpointe=false;

	public static bool isIntro = true;

	public GameObject options;
	public GameObject mainmenu;
	public GameObject menuSound;

	// Use this for initializationj

	void Start (){
		menuSound.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		 
		if (DisableContinue == true) {
				continuelife.GetComponent<Button>().interactable = false; 
			}else
			{
				continuelife.GetComponent<Button>().interactable = true;
			}

	}
	public  void StartGame() {

		DisableContinue = false;

		if (isIntro == true) {
			SceneManager.LoadScene ("intro");
		} else {
			DisableContinue = false;
			SceneManager.LoadScene ("Level1");
			HealthBar.cur_health = 10;
			HealthBar.life = 3;
		}
	}

	public void Continue(){
		
		SceneManager.LoadScene ("Level1");
		HealthBar.cur_health = 10;
		checkpointe = true;
	}




	public void Credit(){
		SceneManager.LoadScene ("credits");
	}

	public void Option(){
		menuSound.SetActive (false);
		options.SetActive(true);
		mainmenu.SetActive(false);
	}

	public void Exit (){
		Application.Quit();

	}
}
