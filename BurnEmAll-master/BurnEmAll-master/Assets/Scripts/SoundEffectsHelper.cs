using UnityEngine;
using System.Collections;

/// <summary>
/// Création d'effets sonores en toute simplicité
/// </summary>
public class SoundEffectsHelper : MonoBehaviour
{

	/// <summary>
	/// Singleton
	/// </summary>
	public static SoundEffectsHelper Instance;

	public AudioClip DuckSound;
	public AudioClip DuckSound2;

	public AudioClip FlowerSoundExplosion;
	public AudioClip BearSound;
	public AudioClip BearSoundCac;
	public AudioClip DeathSound;

	public AudioClip degat1;
	public AudioClip degat2;
	public AudioClip degat3;
	public AudioClip degat4;
	public AudioClip degat5;
	public AudioClip degat6;

	public AudioClip win;

	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}

	public void DoWinSound()
	{
		MakeSound (win);
	}
	public void DoDuckSound()
	{
		MakeSound(DuckSound);

	}

	public void DoDuckSound2()
	{
		MakeSound(DuckSound2);
	}
		

	public void DoFlowerSoundExplosion()
	{
		MakeSound(FlowerSoundExplosion);
	}

	public void DoBearSound()
	{
		MakeSound(BearSound);
	}

	public void DoBearSoundCac()
	{
		MakeSound(BearSoundCac);
	}
	public void DoDeathSound()
	{
		MakeSound(DeathSound);
	}


	public void DoDegat1Sound()
	{
		MakeSound (degat1);
	}
	public void DoDegat2Sound()
	{
		MakeSound (degat2);
	}
	public void DoDegat3Sound()
	{
		MakeSound (degat3);
	}
	public void DoDegat4Sound()
	{
		MakeSound (degat4);
	}
	public void DoDegat5Sound()
	{
		MakeSound (degat5);
	}	public void DoDegat6Sound()
	{
		MakeSound (degat6);
	}



	/// <summary>
	/// Lance la lecture du son
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
