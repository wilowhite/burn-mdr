using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
	public Image Background;
	public Image Bar;	
	public RectTransform TailleBar;

	public int max_health = 10;
	public static int cur_health = 10;
	public static int life = 3;

	public static bool isDead = false;
	public static bool isContinue = false;
	public GameObject deadMenu;
	public GameObject continueMenu;

	public bool doSound = false;

	void start ()
	{
		deadMenu.SetActive(false);
		continueMenu.SetActive(false);

	}

	void Update()
	{
		UpdateHealthBar (cur_health);

		if (cur_health == 0) {
			Transform character = gameObject.GetComponent<Transform>();
			character.rotation = Quaternion.Euler (0, 0, 90);
			SoundEffectsHelper.Instance.DoDeathSound();
			isContinue = true;
			HealthBar.life--;
			cur_health = 10;
		}

		if (life == 0) {
			Transform character = gameObject.GetComponent<Transform>();
			character.rotation = Quaternion.Euler (0, 0, 90);

			isDead = true;
			isContinue = false;
		}
	}
	void OnGUI()
	{
		if (isDead) {
			deadMenu.SetActive (true);

		} else {
			deadMenu.SetActive (false);
		}
		if (isContinue) {
			continueMenu.SetActive (true);
		} else {
			continueMenu.SetActive (false);
		}

	}


	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "rabbit") {
			if (cur_health > 0) {
				cur_health -= 1;
				doSound = true;
				UpdateHealthBar (cur_health);
			}
		}
		if (collision.gameObject.tag == "flower") 
		{
			if (cur_health > 0) {
				cur_health -= 5;
				doSound = true;
				UpdateHealthBar (cur_health);
				SoundEffectsHelper.Instance.DoFlowerSoundExplosion();

			}

		}
		if (collision.gameObject.tag == "duck") 
		{
			if (cur_health > 0) {
				cur_health -= 1;
				doSound = true;
				UpdateHealthBar (cur_health);
				SoundEffectsHelper.Instance.DoDuckSound2();

			}

		}
		if (collision.gameObject.tag == "Bear") 
		{
			if (cur_health > 0) {
				cur_health -= 1;
				doSound = true;
				UpdateHealthBar (cur_health);
			}

		}
	}

	void OnTriggerEnter2D(Collider2D coll) 
	{
		if (coll.tag == "Water") 
		{
			StartCoroutine (SomeCoroutine (2F)); //timer
			cur_health -= cur_health;
			UpdateHealthBar (cur_health);
		}

	}
	public IEnumerator SomeCoroutine(float waitTime) //timer
	{
		Transform character = gameObject.GetComponent<Transform> ();
		character.rotation = Quaternion.Euler (0, 0, 90);
		gameObject.GetComponent<PlayerControllerV3> ().enabled = false;

		yield return new WaitForSeconds (waitTime);


	}



	public void UpdateHealthBar ( float cur_health)
	{
		Bar.fillAmount = cur_health / max_health;
		TailleBar.sizeDelta = new Vector2 (390 * Bar.fillAmount, 25);

		if (Bar.fillAmount == 0.9f && doSound) {
			SoundEffectsHelper.Instance.DoDegat1Sound ();
			doSound = false;
		}
		if (Bar.fillAmount == 0.7f && doSound) {
			SoundEffectsHelper.Instance.DoDegat2Sound ();
			doSound = false;
		}
		if (Bar.fillAmount == 0.5f && doSound) {
			SoundEffectsHelper.Instance.DoDegat3Sound ();
			doSound = false;
		}
		if (Bar.fillAmount == 0.4f && doSound) {
			SoundEffectsHelper.Instance.DoDegat4Sound ();
			doSound = false;
		}		
		if (Bar.fillAmount == 0.3f && doSound) {
			SoundEffectsHelper.Instance.DoDegat5Sound ();
			doSound = false;
		}
		if (Bar.fillAmount == 0.2f && doSound) {
			SoundEffectsHelper.Instance.DoDegat6Sound ();
			doSound = false;
		}



	}

} 