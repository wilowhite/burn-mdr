using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthV4 : MonoBehaviour
{
    public float dropRate = 0.25f;
	public float ashes = 0.01f;
	GameObject Smoke;
	GameObject hearth;

	public Image Background;
	public Image Bar;	
	public RectTransform BarLife;

	public float max_health = 10f;
	public float cur_health = 10f;	

	public bool isKilled = false;

	public float damage = 1;


	private float r = 1;
	private float g = 1;
	private float b = 1;

	void Start() 
	{
        hearth = Resources.Load("gasoline") as GameObject;
		Smoke = Resources.Load("WhiteSmoke") as GameObject;
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.name == "bullet(Clone)")
		{
			cur_health -= damage;
			UpdateHealthBar (cur_health);
		}
	}
	void Update()
	{
		if ((cur_health <= 0) || isKilled) {
			isKilled = false;
			Destroy (gameObject);
			float drop = Random.Range (0f, 1f);
			if (drop <= dropRate) {
				GameObject poke = Instantiate (hearth) as GameObject;
				poke.transform.position = transform.position;
			}

		}
	}
	

	void OnParticleCollision(GameObject other)
	{
		cur_health--;
		UpdateHealthBar (cur_health);

		r = r - ashes;
		g = g - ashes;
		b = b - ashes;

		if (r <= 0.41f && r>= 0.40f) {
			GameObject fumee = Instantiate (Smoke) as GameObject;
			fumee.transform.parent = gameObject.transform;
			fumee.transform.position = gameObject.transform.position;
		}

		GetComponent<SpriteRenderer>().color = new Color (r, g, b, 1);


	}
	public void UpdateHealthBar ( float cur_health)
	{
		Bar.fillAmount = cur_health / max_health;
		BarLife.sizeDelta = new Vector2 (390 * Bar.fillAmount, 25);
		if (Bar.fillAmount == 0f) {
			isKilled = true;
		}
	}
}