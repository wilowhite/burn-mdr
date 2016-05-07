using UnityEngine;
using System.Collections;

public class decoreBurn : MonoBehaviour {

	GameObject Fire;

	public GameObject decore;
	private Transform decor;

	float r = 1;
	float g = 1;
	float b = 1;

	void Start() 
	{
		Fire = Resources.Load("DecoreBurn") as GameObject;
		decor = decore.transform;
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

	void OnParticleCollision(GameObject other)
	{
		r = r - 0.005f;
		g = g - 0.005f;
		b = b - 0.005f;

		GetComponent<SpriteRenderer>().color = new Color (r, g, b, 1);

		if (r <= 0.50f) 
		{
			r = r + 0.003f;
			g = g + 0.003f;
			b = b + 0.003f;

		}
		if (r <= 0.41f && r>= 0.40f) {
			EffectHelper.Instance.Death (transform.position);
		}

		if (r <= 0.15f)
		{

			Destroy(gameObject);
		}
	}
}