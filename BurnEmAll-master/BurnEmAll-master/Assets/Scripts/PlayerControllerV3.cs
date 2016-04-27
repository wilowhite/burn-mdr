/// <summary>
/// Player controller.
/// mouvement personnage 
/// double jump
/// définition plateforme
/// caméra = limite personnage
/// </summary>


using UnityEngine;
using System.Collections;

public class PlayerControllerV3 : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public float Speed;

	public Transform groundVerification;
	public float groundVerificationRadius;
	public LayerMask groundWhat;
	private bool grounded;

	public bool doubleJumped;

	private Animator anim;

	public static bool disableEnnemy;
	public GameObject ennemy;

	void Start()
	{
		disableEnnemy = true;
	}

	void FixedUpdate() 
	{
		anim = gameObject.GetComponent<Animator> ();
		grounded = Physics2D.OverlapCircle (groundVerification.position, groundVerificationRadius, groundWhat);
	}

	// Update is called once per frame
	void Update () {
			anim.SetBool ("Grounded", grounded);
			anim.SetFloat ("Speed", Mathf.Abs (Input.GetAxis ("Horizontal")));
			if (Input.GetAxis ("Horizontal") < -0.1f) {
				transform.localScale = new Vector3 (-1, 1, 1);
			}
			if (Input.GetAxis ("Horizontal") > 0.1f) {
				transform.localScale = new Vector3 (1, 1, 1);
			}

			if (grounded) //si le joueur est au sol
			doubleJumped = false;

			if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) {
				disableEnnemy = false;
				jumpHeight = 15;
				Jump ();
			}

			if (Input.GetKeyDown (KeyCode.UpArrow) && !doubleJumped && !grounded) {
				jumpHeight = 9;
				Jump ();
				doubleJumped = false;
			}

			if (Input.GetKey (KeyCode.LeftArrow)) 
			{
					disableEnnemy = false;

					GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}

			if (Input.GetKey (KeyCode.RightArrow)) {
				disableEnnemy = false;

				GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}


		if (disableEnnemy) {        
			ennemy.SetActive (false);
		} else {
			ennemy.SetActive (true);
		}

			//delimit joueur camera
			var dist = (transform.position - Camera.main.transform.position).z;

			var leftBorder = Camera.main.ViewportToWorldPoint (
				                new Vector3 (0, 0, dist)
			                ).x;

			var rightBorder = Camera.main.ViewportToWorldPoint (
				                 new Vector3 (1, 0, dist)
			                 ).x;

			var topBorder = Camera.main.ViewportToWorldPoint (
				               new Vector3 (0, 0, dist)
			               ).y;

			var bottomBorder = Camera.main.ViewportToWorldPoint (
				                  new Vector3 (0, 1, dist)
			                  ).y;

			transform.position = new Vector3 (
				Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
				Mathf.Clamp (transform.position.y, topBorder, bottomBorder),
				transform.position.z
			);
	}



	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}