using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{   // Il faut attacher ce script au "FirePoint" et désactiver le "weapon" de arm.
    public int amount = 10;                                         // Force de frappe du petit bonhomme
    public float fireRate = 0;
    public float timeToFire = 0;
    GameObject BulletTrailPrefab;                                     // j'ai putin de galéré pour enfin trouver un code qui marche à peu près
    private Renderer FirePoint;
    void Start()
    {
        BulletTrailPrefab = Resources.Load("bullet") as GameObject;  // Bizarrement il faut créer un dossier resources pour qu'il le trouve,
        FirePoint = GetComponent<Renderer>();                        // si on laisse dans "prefabs" il ne trouve pas.(J'ai déjà
       // essayé de remplacer "Resources" par "Prefabs")
    }

    void Update()
    {
        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                Shoot();
            }
        }
        else {
            if (Time.time > timeToFire)
            {
                FirePoint.enabled = true;
            }
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {

                timeToFire = Time.time + 1 / fireRate;              // L'idée ce serait de "cacher" la torche 
                Shoot();
                                                            // pendant le rechargement et de la faire réapparraître
                FirePoint.enabled = false;
            }
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(BulletTrailPrefab) as GameObject;
        Vector3 mp = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 dir = (Input.mousePosition - mp).normalized;
        bullet.transform.position = transform.position;             // C'est pour que la torche part de la main et non au milieu
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();        // C'est ça qui va permettre à la torche de voler 
        rb.velocity = (dir * amount);                               //il tire maintenant selon la pos de la souris
    }
}
