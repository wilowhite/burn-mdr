using UnityEngine;
using System.Collections;

public class OptionsGUI : MonoBehaviour {

	public GameObject options;
	public GameObject mainmenu;

	// Use this for initialization
	void Start () {
		options.SetActive(false);
		mainmenu.SetActive(true);
	}
	

	public void Return(){
		options.SetActive(false);
		mainmenu.SetActive(true);
	}

	public void Website(){

		Application.OpenURL ("http://yanato.github.io/project/");
	}
}
