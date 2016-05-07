using UnityEngine;
using System.Collections;

public class EffectHelper : MonoBehaviour {

	public ParticleSystem smokeEffect;

	public static EffectHelper Instance;

	void Awake()
	{
		// On garde une référence du singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SpecialEffectsHelper!");
		}

		Instance = this;
	}

	public void Death (Vector3 position)
	{
		instantiate (smokeEffect, position);
	}

	private ParticleSystem instantiate (ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate (prefab, position, Quaternion.identity) as ParticleSystem;
		Destroy (newParticleSystem.gameObject, newParticleSystem.startLifetime);


		return newParticleSystem;
	}
}
