using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class deadMenu : MonoBehaviour {


	public void Restart()
	{
		HealthBar.isDead = false;
		HealthBar.cur_health = 10;
		HealthBar.life = 3;
		SceneManager.LoadScene ("Level1");
		Checkpoint.check = false;


	}
	public void Exit (){
		SceneManager.LoadScene ("Menu");
		HealthBar.isDead = false;
		MainMenu.DisableContinue = true;
		Checkpoint.check = false;

	}
}
