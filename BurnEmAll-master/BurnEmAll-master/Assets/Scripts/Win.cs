using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	public static bool end = false;
	public GameObject bear;
	public GameObject endmenu;
	public GameObject mainmusic;

	public bool doSound;
	void Start (){
		endmenu.SetActive (false);
		doSound = true;
	}
	// Update is called once per frame
	void Update () {
		if (bear == null) {
			end = true;
			if (doSound) {
				SoundEffectsHelper.Instance.DoWinSound ();
				mainmusic.SetActive (false);
				doSound = false;
			}

		}
		if (end) {
			endmenu.SetActive (true);

		}
	}
}
