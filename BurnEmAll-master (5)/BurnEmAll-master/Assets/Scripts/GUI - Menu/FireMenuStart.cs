using UnityEngine;
using System.Collections;

public class FireMenuStart : MonoBehaviour {

	GameObject Fire;
	public GameObject decore;
	private Transform decor;
	Rigidbody2D button;



	void Start () 
	{
		Fire = Resources.Load("FireGUI") as GameObject;
		decor = decore.transform;
		button = decore.GetComponents<Rigidbody2D>()[0];

	}

	// Update is called once per frame
	public void leFeu () 
	{
		GameObject feu = Instantiate (Fire) as GameObject;
		feu.transform.parent = decor;
		feu.transform.position = decor.transform.position - new Vector3 (0,0,4);

		GameObject feu2 = Instantiate (Fire) as GameObject;
		feu2.transform.parent = decor;
		feu2.transform.position = decor.transform.position - new Vector3 (45,0,4);

		GameObject feu3 = Instantiate (Fire) as GameObject;
		feu3.transform.parent = decor;
		feu3.transform.position = decor.transform.position - new Vector3 (-45,0,4);

		GameObject feu4 = Instantiate (Fire) as GameObject;
		feu4.transform.parent = decor;
		feu4.transform.position = decor.transform.position - new Vector3 (22,0,4);

		GameObject feu5 = Instantiate (Fire) as GameObject;
		feu5.transform.parent = decor;
		feu5.transform.position = decor.transform.position - new Vector3 (-22,0,4);

		button.constraints = RigidbodyConstraints2D.None;
	}

}
