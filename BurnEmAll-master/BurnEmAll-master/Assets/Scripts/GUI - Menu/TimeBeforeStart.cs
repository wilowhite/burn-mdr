using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimeBeforeStart : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D coll)
	{
		SceneManager.LoadScene ("Level1");
	}
}
