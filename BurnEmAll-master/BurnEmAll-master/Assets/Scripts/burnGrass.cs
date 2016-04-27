using UnityEngine;
using System.Collections;

public class burnGrass : MonoBehaviour {

	GameObject Fire;
	private Transform decor;
	void Start() 
	{
		Fire = Resources.Load("Fire torche") as GameObject;
		decor = gameObject.transform;
	}

	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.tag == "bullet") 
		{
			GameObject Feu = Instantiate (Fire) as GameObject;         //faire un délai de temps, une limite à 1 et prendre les positions de la torche etc. = pas fini
			Feu.transform.parent = decor;
			Feu.transform.position = decor.transform.position;
		}
	}
}