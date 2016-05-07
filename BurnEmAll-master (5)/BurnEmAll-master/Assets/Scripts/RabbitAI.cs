using UnityEngine;
using System.Collections;

public class RabbitAI : MonoBehaviour {

	public bool freezeRotation = true;

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundVerification;
	public float groundVerificationRadius;
	public LayerMask groundWhat;
	private bool grounded;




	void FixedUpdate() 
	{
		grounded = Physics2D.OverlapCircle (groundVerification.position, groundVerificationRadius, groundWhat);
	}

	// Update is called once per frame
	void Update () {


		if (grounded) 
		{
			Jump();
		}

		var epos = gameObject.transform.position;
		var player = GameObject.Find("Player");
		Vector3 ppos = (player.transform.position);
		Vector2 Sens = new Vector2(ppos.x - epos.x, ppos.y - epos.y).normalized;



		if(Sens.x > 0) 
		{
			gameObject.transform.localScale = new Vector3(-1, 1, 1);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
		else 
		{
			gameObject.transform.localScale = new Vector3(1, 1, 1);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}


	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}