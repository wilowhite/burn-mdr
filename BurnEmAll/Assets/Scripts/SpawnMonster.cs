using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour
{

    private bool hasSpawn;
	private Vector3 spawnPos;
    // Use this for initialization
    void Start()
    {
        hasSpawn = false;
		spawnPos = gameObject.transform.position;
    }

    void Update()
    {
        var enn = gameObject.transform.position;
        var player = GameObject.Find("Player");
		Vector3 ppos = (player.transform.position);
        if (hasSpawn == false)
        {
			gameObject.transform.position = spawnPos;
            if ((enn.x - ppos.x) < 14)
            {
                hasSpawn = true;
            }
        }
    }
}
