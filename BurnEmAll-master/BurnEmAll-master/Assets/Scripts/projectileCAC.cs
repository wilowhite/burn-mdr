using UnityEngine;
using System.Collections;

public class projectileCAC : MonoBehaviour
{

    public GameObject fire;
	public GameObject torche;
    private Renderer FirePoint;


    void Start()
    {
        fire.SetActive(false);
        FirePoint = GetComponent<Renderer>();
		torche.GetComponent<PolygonCollider2D> ().enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && FirePoint.enabled)
        {
            fire.SetActive(true);
			torche.GetComponent<PolygonCollider2D> ().enabled = true;
		}
        else {
            fire.SetActive(false);
			torche.GetComponent<PolygonCollider2D> ().enabled = false;

        }


    }
}

