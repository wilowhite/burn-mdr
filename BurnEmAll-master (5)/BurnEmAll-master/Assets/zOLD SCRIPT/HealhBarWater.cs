using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealhBarWater : MonoBehaviour {

		public Image Background;
		public Image Bar;	
		public RectTransform TailleBar;

		public int max_health = 10;
		public static int cur_health = 10;
		public static int life = 3;

		public static bool isDead = false;
		public GameObject deadMenu;
		int i = 0;

		float j = 0f;
		public GameObject leau;
		public bool wet;

		void start ()
		{
			deadMenu.SetActive(false);
		}

		void Update()
		{
			if (cur_health == 0) 
			{
				HealthBar.cur_health = 10;
				SceneManager.LoadScene ("Level1");
				wet = false;
				StartCoroutine (WaitLoading (2F)); //timer
				life--;

			}
			if (life == 0) 
			{
				Transform character = gameObject.GetComponent<Transform> ();
				character.rotation = Quaternion.Euler (0, 0, 90);
				i++;
				if (i > 50) 
				{
					isDead = true;
				}
			}
			if (wet == true) {
				j += 0.003f;
				Transform character = gameObject.GetComponent<Transform> ();
				character.rotation = Quaternion.Euler (0, 0, 90);
				Transform flotte = leau.GetComponent<Transform> ();
				character.position = new Vector3 (flotte.position.x, flotte.position.y + 0.8f - j, flotte.position.z);
				gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
				gameObject.GetComponent<PlayerControllerV3> ().enabled = false;
			} else {
				gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
				gameObject.GetComponent<PlayerControllerV3> ().enabled = true;
			}
		}


		void OnGUI()
		{
			if (isDead) {
				deadMenu.SetActive (true);

			} else {
				deadMenu.SetActive (false);
			}
		}


		void OnCollisionEnter2D(Collision2D collision)
		{

			if (collision.gameObject.tag == "rabbit") 
			{
				if (cur_health > 0) 
				{
					cur_health -= 1;
					UpdateHealthBar (cur_health);
				}
			}
			if (collision.gameObject.tag == "flower") 
			{
				if (cur_health > 0) {
					cur_health -= 5;
					UpdateHealthBar (cur_health);
				}
			}
			if (collision.gameObject.tag == "duck") 
			{
				if (cur_health > 0) 
				{
					cur_health -= 1;
					UpdateHealthBar (cur_health);
				}
			}
		}

		void OnTriggerEnter2D(Collider2D coll) 
		{
			if (coll.tag == "Water") 
			{
				wet = true;
				StartCoroutine (SomeCoroutine (2F)); //timer
			}

		}
		public IEnumerator SomeCoroutine(float waitTime) //timer
		{
			yield return new WaitForSeconds (waitTime);
			cur_health -= cur_health;
			UpdateHealthBar (cur_health);
		}

		public IEnumerator WaitLoading(float waitTim) //timer
		{
			yield return new WaitForSeconds (waitTim);
		}


		public void UpdateHealthBar ( float cur_health)
		{
			Bar.fillAmount = cur_health / max_health;
			TailleBar.sizeDelta = new Vector2 (390 * Bar.fillAmount, 25);

		}

	} 