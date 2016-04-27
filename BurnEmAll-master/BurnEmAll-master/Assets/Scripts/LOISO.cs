using UnityEngine;
using System.Collections;

public class LOISO : MonoBehaviour
{
    
    public bool freezeRotation = true;
    public int yspeed = 5;
    public int speed = 5;
    public Vector2 direction = new Vector2(1, 0);
    GameObject egg;

    void Update(){
        egg = Resources.Load("eggs duck") as GameObject;
        var canard = gameObject.transform.position;
        var player = GameObject.Find("Player");
		Vector2 ppos = player.transform.position;
        if (canard.y <= 1.6)
        {
                Jump();
        }
        if ((canard.x - ppos.x) < 0.3 && (canard.x - ppos.x) > 0){
            GameObject oeuf = Instantiate(egg) as GameObject;
			oeuf.transform.position = transform.position - new Vector3 (0,1,0);
        }
    }
    void Jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x * -speed, yspeed * 1);
    }
}

