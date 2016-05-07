using UnityEngine;
using System.Collections;

public class Disparation : MonoBehaviour
{                                      

    public int disparation = 3; 

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, disparation);
    }

}
