using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    public float hp = 1;

    /// <summary>
    /// Ennemi ou joueur ?
    /// </summary>
    public bool isEnemy = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Est-ce un tir ?
        Disparation shot = collider.gameObject.GetComponent<Disparation>();
        if (shot != null)
        {
            // Tir allié
            if (shot.isEnemyShot != isEnemy)
            {
                hp -= shot.damage;
                if (hp <= 0)
                {
                    // Destruction !
                    Destroy(gameObject);
                }
            }
        }
    }
}