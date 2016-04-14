using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public Image Background;
	public Image Bar;	

	public int max_health = 10;
	public int cur_health = 10;	

	public void OnCollisionEnter(Collision collision)
	{
		switch (collision.gameObject.tag)
		{
		case "Ennemy":
			if (cur_health > 0)
			{
				cur_health -= 1;
				UpdateHealthBar (cur_health);
			}
			break;

		case "HealthPack":
			if (cur_health < max_health)
			{
				cur_health += 1;
				UpdateHealthBar (cur_health);
			}
			break;

		default:
			break;
		}
	}

	public void UpdateHealthBar ( float cur_health)
	{
		Bar.fillAmount = cur_health / max_health;
	}
			
} 