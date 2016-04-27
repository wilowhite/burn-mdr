using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthV3 : MonoBehaviour
{
	public float ashes = 0.01f;
	GameObject Smoke;

	public Image Background;
	public Image Bar;	
	public RectTransform BarLife;

	public float max_health = 10f;
	public float cur_health = 10f;	

	public GameObject decore;
	private Transform decor;



	private float r = 1;
	private float g = 1;
	private float b = 1;

	void Start() 
	{
		Smoke = Resources.Load("WhiteSmoke") as GameObject;
		decor = decore.transform;
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Disparation bullet = collider.gameObject.GetComponent<Disparation>();
		if (collider.gameObject.name == "bullet(Clone)")
		{
			cur_health -= bullet.damage;
			UpdateHealthBar (cur_health);
		}

		if (cur_health <= 0)
		{
			Destroy(gameObject);
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
			fumee.transform.parent = decor;
			fumee.transform.position = decor.transform.position;
		}

		GetComponent<SpriteRenderer>().color = new Color (r, g, b, 1);

		if (cur_health <= 0)
		{
			Destroy(gameObject);
		}
	}
	public void UpdateHealthBar ( float cur_health)
	{
		Bar.fillAmount = cur_health / max_health;
		BarLife.sizeDelta = new Vector2 (390 * Bar.fillAmount, 25);

	}
}