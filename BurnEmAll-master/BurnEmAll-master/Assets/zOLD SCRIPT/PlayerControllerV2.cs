/// <summary>
/// Player controller.
/// mouvement personnage 
/// double jump
/// définition plateforme
/// caméra = limite personnage
/// </summary>


using UnityEngine;
using System.Collections;

public class PlayerControllerV2 : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundVerification;
	public float groundVerificationRadius;
	public LayerMask groundWhat;
	private bool grounded;

	public bool doubleJumped;


	void FixedUpdate() 
	{
		grounded = Physics2D.OverlapCircle (groundVerification.position, groundVerificationRadius, groundWhat);

	}

	// Update is called once per frame
	void Update () {
		if (grounded) //si le joueur est au sol
			doubleJumped = false;

		if (Input.GetKeyDown (KeyCode.Z) && grounded) 
		{
			jumpHeight = 15;
			Jump();
		}

		if (Input.GetKeyDown (KeyCode.Z) && !doubleJumped && !grounded) 
		{
			jumpHeight = 9;
			Jump();
			doubleJumped = true;
		}

		if (Input.GetKey (KeyCode.Q)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}


		//delimit joueur camera
		var dist = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
		).x;

		var rightBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(1, 0, dist)
		).x;

		var topBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
		).y;

		var bottomBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 1, dist)
		).y;

		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
			transform.position.z
		);

	}





	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}