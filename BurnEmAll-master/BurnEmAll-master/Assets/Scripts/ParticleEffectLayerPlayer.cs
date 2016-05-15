/// <summary>
/// Particle effect layer.
/// script utilisé car le layer des particules reste toujours deriere les autres layers crées.
/// mettre ce script sur les particules en question
/// </summary>
using UnityEngine;
using System.Collections;

public class ParticleEffectLayerPlayer : MonoBehaviour {

	void Start ()
	{
		//Change Foreground to the layer you want it to display on 
		//You could prob. make a public variable for this
		GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "Player";

	}
}
