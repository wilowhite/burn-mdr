/// <summary>
///  déplacement de la caméra en fonction du joueur avec un effet smooth
///  délimitation de la caméra en certaines position
/// retour en arrière de la caméra limité
/// </summary>

using UnityEngine;
using System.Collections;

public class SmoothCameraV2 : MonoBehaviour {

	private Vector2 velocity;

	public float smoothTimeY;
	public float smoothTimeX;

	public GameObject player;

	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void FixedUpdate()
	{
		
			float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
			float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

		if (velocity.x >= 0) {
			transform.position = new Vector3 (posX, posY, transform.position.z);
		} else {
			transform.position = new Vector3 (transform.position.x, posY, transform.position.z);

		}

		if (bounds) 
		{
			transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x),
				Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y),
				Mathf.Clamp (transform.position.z, minCameraPos.z, maxCameraPos.z));
		}




	}


}
