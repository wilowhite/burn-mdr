using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	[SerializeField] Transform player;

	private Vector2 moveTemp;

	[SerializeField] float speed = 3;
	[SerializeField] float differenceX;
	[SerializeField] float differenceY;

	[SerializeField] float movementThresholdX = 3;
	[SerializeField] float movementThresholdY = 1;


	// Update is called once per frame
	void Update () 
	{

		if (player.transform.position.x > transform.position.x)
			{
				differenceX = player.transform.position.x - transform.position.x;
			}	
			else 
				{
					differenceX = transform.position.x - player.transform.position.x;
				}
			

		if( differenceX >= movementThresholdX) 
			{
				moveTemp = player.transform.position;
				moveTemp.y = 0;
				transform.position = Vector2.MoveTowards (transform.position, moveTemp, speed * Time.deltaTime);
			}

		if( differenceY >= movementThresholdY) 
			{
				moveTemp = player.transform.position;
				transform.position = Vector2.MoveTowards (moveTemp, transform.position, speed * Time.deltaTime);
			}	
	}
}		
