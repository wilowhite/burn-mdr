using UnityEngine;
using System.Collections;

public class DuFEU : MonoBehaviour
{
    GameObject Fire;
    void Start() {
        Fire = Resources.Load("Fire torche") as GameObject;
    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider == true)
        {
            GameObject Feu = Instantiate(Fire) as GameObject;         //faire un délai de temps, une limite à 1 et prendre les positions de la torche etc. = pas fini
			Feu.transform.parent = coll.transform;
			Feu.transform.position = coll.transform.position;
        }
	}
}
