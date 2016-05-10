using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {

	public static bool isPause = false;
	public GameObject menu;

	public GameObject options;
	public GameObject level;
	public GameObject healthbar;
	public GameObject health;
	public GameObject pause;
    public GameObject music;

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
	public void Options()
	{
		options.SetActive(true);
		pause.SetActive(false);
		level.SetActive(false);
		health.SetActive(false);	
		healthbar.SetActive(false);
        music.SetActive(false);

	}
	public void Return()
	{
		options.SetActive(false);
		pause.SetActive(true);
		level.SetActive(true);
		health.SetActive(true);	
		healthbar.SetActive(true);
        music.SetActive(true);

    }
    public void Website(){

		Application.OpenURL ("http://yanato.github.io/project/");
	}
}
