using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

	public static bool isPause = false;
	public GameObject menu;

	void start ()
	{
		menu.SetActive(false);

	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			isPause = !isPause;
		}


		if (isPause || HealthBar.isDead || HealthBar.isContinue)
		{
			Time.timeScale = 0;
		}else{
			Time.timeScale = 1;
		}


	}

	void OnGUI()
	{
		if (isPause) {
			menu.SetActive (true);

		} else {
			menu.SetActive (false);
		}
	}

	public void Resume ()
	{
		isPause = false;
	}

	public void Exit()
	{
		SceneManager.LoadScene ("Menu");
		isPause = false;
	}

}
