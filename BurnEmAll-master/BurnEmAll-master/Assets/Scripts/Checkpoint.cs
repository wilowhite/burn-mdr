using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	public GameObject fire;
	public bool onfire;
	public static bool takePos;
	public static bool check;

	public static Vector3 CheckpointPosition;
	// Use this for initialization
	void Start () {
		fire.SetActive(false);
		onfire = false;
		takePos = false;
		check = false;
	}



	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "bullet") {
			if (onfire == false) {
				fire.SetActive (true);
				takePos = true;
				onfire = true;
				check = true;
			}
		}

	}
}
