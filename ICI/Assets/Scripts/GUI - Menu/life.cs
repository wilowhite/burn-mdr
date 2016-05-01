using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class life : MonoBehaviour {

	Text texte;
	int i;

	// Use this for initialization
	void Start() {
		texte = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (HealthBar.life == 3)
		{
			texte.text = "x 3";
		}
		if (HealthBar.life == 2)
		{
			texte.text = "x 2";
		}
		if (HealthBar.life == 1)
		{
			texte.text = "x 1";
		}
		if (HealthBar.life == 0)
		{
			texte.text = "x 0";
		}
	}
}
