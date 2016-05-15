using UnityEngine;
using System.Collections;

public class FlowerAI : MonoBehaviour {

	public bool freezeRotation = true;

	public float moveSpeed;
	public float jumpHeight;

	GameObject Explosion;

	void Start() 
	{
		Explosion = Resources.Load("explosion flamme") as GameObject;
	}

	void Update () {

		var epos = gameObject.transform.position;
		Vector2 Sens = new Vector2(PlayerControllerV3.ppos.x - epos.x, PlayerControllerV3.ppos.y - epos.y).normalized;
		var xpos = (PlayerControllerV3.ppos.x - epos.x);

		if(Sens.x > 0) 
		{
			gameObject.transform.localScale = new Vector3(-1, 1, 1);
			if (xpos > 2.2) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
		}
		else 
		{
			gameObject.transform.localScale = new Vector3(1, 1, 1);
			if (xpos < -2.2) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if (coll.gameObject.name == "Player") 
		{
			GameObject boom = Instantiate (Explosion) as GameObject;
			boom.transform.position = gameObject.transform.position;
			Destroy(gameObject);

		}

	}
}