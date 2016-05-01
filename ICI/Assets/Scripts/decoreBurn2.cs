using UnityEngine;
using System.Collections;

public class decoreBurn2 : MonoBehaviour {

	GameObject Fire;
	GameObject Smoke;

	public GameObject decore;
	private Transform decor;

	private float r = 1;
	private float g = 1;
	private float b = 1;
	private float a;

	public float ashes = 0.01f;
	public float limitAshes = 0.005f;


	void Start() 
	{
		Fire = Resources.Load("DecoreBurn") as GameObject;
		Smoke = Resources.Load("WhiteSmoke") as GameObject;
		decor = decore.transform;
		a = GetComponent<SpriteRenderer> ().color.a;
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
		r = r - ashes;
		g = g - ashes;
		b = b - ashes;

		GetComponent<SpriteRenderer>().color = new Color (r, g, b, a);

		if (r <= 0.50f) 
		{
			r = r + limitAshes;
			g = g + limitAshes;
			b = b + limitAshes;

		}
		if (r <= 0.41f && r>= 0.40f) {
			GameObject fumee = Instantiate (Smoke) as GameObject;         //faire un délai de temps, une limite à 1 et prendre les positions de la torche etc. = pas fini
			fumee.transform.parent = decor;
			fumee.transform.position = decor.transform.position;
		}

		if (r <= 0.15f)
		{

			Destroy(gameObject);
		}
	}
}