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

	public AudioClip FlowerSound;
	public AudioClip FlowerSoundExplosion;
	public AudioClip BearSound;
	public AudioClip BearSoundCac;
	public AudioClip DeathSound;


	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}

	public void DoDuckSound()
	{
		MakeSound(DuckSound);

	}

	public void DoDuckSound2()
	{
		MakeSound(DuckSound2);
	}

	public void DoFlowerSound()
	{
		MakeSound(FlowerSound);
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

	/// <summary>
	/// Lance la lecture du son
	/// </summary>
	/// <param name="originalClip"></param>
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}
