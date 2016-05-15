using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour
{

    private bool hasSpawn;
	private Vector3 spawnPos;
    // Use this for initialization
    void Start()
    {
		spawnPos = gameObject.transform.position;
		foreach( Transform child in transform )
		{
			child.gameObject.SetActive( false );
		}         
		hasSpawn = false;

    }

    void Update()
    {
        if (hasSpawn == false)
        {
			if ((spawnPos.x - PlayerControllerV3.ppos.x) < 14)
            {
				foreach( Transform child in transform )
				{
					child.gameObject.SetActive( true );
					child.transform.position = spawnPos;
				} 
				hasSpawn = true;
            }
        }
    }
}
