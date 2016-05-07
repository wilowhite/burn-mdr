using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TexteCredit : MonoBehaviour {
	Text texte;
	public Text names;
	public GameObject Player;
	public float xpos;
	// Use this for initialization
	void Start() {
		texte = GetComponent<Text>();
		//     string message; et message = texte.text;
	}

	void Update()
	{
		xpos = Player.transform.position.x;
		if (-8<xpos && xpos < -5) {
			texte.text = "Development / Code :";
			names.text = "TOUCHAIS Mickael\nCHOU Antoine\nMESSE Thibault";
		}
		if (-5<xpos && xpos<-2){
			texte.text = "Graphic design :";		
			names.text = "TOUCHAIS Mickael\nReactorCore Games (Pixel Art Pack)";
		}
		if (-2 < xpos && xpos< 1) {
			texte.text = "Sounds effect / Musics:";
			names.text = "TOUCHAIS Mickael\nMESSE Thibault (bear sound)\n'Drorki' (duck sound)\n\nLENCOU Quentin (Overworld 8bit music)\n'L'hermite moderne' (Je code avec le cul music)";

		}
		if (1 < xpos && xpos< 4) {
			texte.text = "Assistants / Helper / Advisors :";
			names.text = "Flamoure (pyroman assistant)";
		}
		if (4 < xpos && xpos< 8) {
			texte.text = "Betatesters :";
			names.text = "Names here";
		}
	}
}
