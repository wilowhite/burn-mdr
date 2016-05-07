using UnityEngine;
using System.Collections;

public class RabbitAIOLD : MonoBehaviour
{
    public bool freezeRotation = true;
    public Vector2 speed = new Vector2(5,5);

    void Update()
    {
                var epos = gameObject.transform.position;
                var player = GameObject.Find("Player");
                Vector3 ppos = (player.transform.position);
                Vector2 Sens = new Vector2(ppos.x - epos.x, ppos.y - epos.y).normalized;
                var xpos = (ppos.x - epos.x);
                Vector2 BougeSonGrosCul = new Vector2(Sens.x * speed.x, Sens.y * 1);
                        if((xpos > 1.5) && (Sens.y>0.5)) {
            BougeSonGrosCul = new Vector2(Sens.x * speed.x, Sens.y * speed.y);
                                  }
        if(Sens.x > 0) 
		{
			gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }else 
		{
        	gameObject.transform.localScale = new Vector3(1, 1, 1);

		}
       	GetComponent<Rigidbody2D>().velocity = BougeSonGrosCul;
    }
}
