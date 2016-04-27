using UnityEngine;
using System.Collections;

public class EggDamages : MonoBehaviour {

	GameObject Explosion;


	void Start() 
	{
		Explosion = Resources.Load("explosion eggs") as GameObject;

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