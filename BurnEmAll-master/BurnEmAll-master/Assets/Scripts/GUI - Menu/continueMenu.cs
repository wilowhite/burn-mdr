using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class continueMenu : MonoBehaviour {

	public GameObject Camera;
	public GameObject Player;
	public static Vector3 CheckpointPosition;

	void Update(){
		if (Checkpoint.takePos == true) {
			 CheckpointPosition = Camera.GetComponent<Transform> ().position;
			Debug.Log (CheckpointPosition);
			Checkpoint.takePos = false;
		}
	}

	public void Continue (){

		HealthBar.isContinue = false;
		HealthBar.cur_health = 10;
		if (Checkpoint.check == true) {
			Camera.transform.position = new Vector3 (CheckpointPosition.x, 0, 5);
			Player.transform.position = new Vector3 (Camera.transform.position.x, 0, 5);

			Checkpoint.check = false;
		} else {
			Camera.transform.position = new Vector3 (0, 0, 5);
			Player.transform.position = new Vector3 (-7f, -2.5f, 5f);

		}
		Debug.Log (Camera.transform.position);
		Transform character = Player.GetComponent<Transform>();
		character.rotation = Quaternion.Euler (0, 0, 0);
		character.GetComponent<PlayerControllerV3> ().enabled = true;
		PlayerControllerV3.disableEnnemy = true;



	}

	public void Exit (){
		SceneManager.LoadScene ("Menu");
		HealthBar.isContinue = false;
	}
}
