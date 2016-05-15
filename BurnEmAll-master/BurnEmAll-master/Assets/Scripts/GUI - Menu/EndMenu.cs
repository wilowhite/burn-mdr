using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

	public void Exit () {
		Application.Quit();
	}
	
	public void credits () {
		SceneManager.LoadScene ("Menu");
	}
}
