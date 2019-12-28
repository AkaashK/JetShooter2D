using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

    public GameObject gameoverExplosion;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "bullet")
        {
            Instantiate(gameoverExplosion, transform.position, transform.rotation);

        }
    }
}
