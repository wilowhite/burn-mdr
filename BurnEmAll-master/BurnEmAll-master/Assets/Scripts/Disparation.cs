using UnityEngine;
using System.Collections;

public class Disparation : MonoBehaviour
{                                       // à attacher sur "bullet" de "Resources"
    public float damage = 1;              // Rip Tiborc
    public bool isEnemyShot = false;
    public int disparation = 5;         // On pourra changer selon l'arme comme ça

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, disparation);
    }

}
